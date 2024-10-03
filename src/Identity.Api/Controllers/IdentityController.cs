using Identity.Api.Models.RequestModels;
using Identity.Api.Models.ResponseModels;
using Identity.Api.Services.TokenService;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Api.Controllers
{
    [ApiController]
    [Route("/api/v1")]
    public class IdentityController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IEmailSender<User> _emailSender;
        private readonly ILogger<IdentityController> _logger;
        private readonly JwtConfig _jwtConfig;
        private readonly ITokenService _tokenService;

        public IdentityController(
            UserManager<User> userManager,
            IEmailSender<User> emailSender,
            ILogger<IdentityController> logger,
            IOptions<JwtConfig> jwtOptions,
            ITokenService tokenService)
        {
            _userManager = userManager;
            _emailSender = emailSender;
            _tokenService = tokenService;
            _logger = logger;
            _jwtConfig = jwtOptions.Value;
        }

        [HttpGet("confirmEmail")]
        public async Task<IActionResult> ConfirmEmail([FromQuery] ConfirmEmailRequest req)
        {
            var user = await _userManager.FindByEmailAsync(req.Email);
            if (user is null)
            {
                return Problem(statusCode: StatusCodes.Status400BadRequest, detail: "Not found user");
            }

            var identityResult = await _userManager.ConfirmEmailAsync(user, req.Code);
            if (!identityResult.Succeeded)
            {
                var errors = identityResult.Errors.Select(i => i.Description);
                return Problem(statusCode: StatusCodes.Status400BadRequest, detail: errors.First());
            }

            return Ok(ResponseObject.Succeeded);
        }

        [Authorize]
        [HttpGet("manageInfo")]
        public IActionResult ManageInfo()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.Sid);
            var email = this.User.FindFirstValue(ClaimTypes.Email);
            var roles = this.User.FindAll(ClaimTypes.Role);

            return Ok(new ManageInfoResponse
            {
                UserId = userId,
                Email = email,
                Roles = roles.Select(role => role.Value).ToList(),
            });
        }

        [Authorize]
        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            var email = this.User.FindFirstValue(ClaimTypes.Email);
            var user = await _userManager.FindByEmailAsync(email!);
            if (user is null)
            {
                return Problem(statusCode: StatusCodes.Status401Unauthorized);
            }

            user.RefreshToken = null;
            user.RefreshTokenExpiryTime = null;
            var identityResult = await _userManager.UpdateAsync(user);
            if (!identityResult.Succeeded)
            {
                return Problem();
            }
            this.HttpContext.Response.Cookies.Delete("access-token");
            this.HttpContext.Response.Cookies.Delete("refresh-token");

            return Ok(ResponseObject.Succeeded);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest req)
        {
            var user = new User
            {
                Email = req.Email,
            };

            var identityResult = await _userManager.CreateAsync(user, req.Password);
            if (!identityResult.Succeeded)
            {
                return Problem();
            }

            identityResult = await _userManager.AddToRoleAsync(user, RolesConstant.Customer);
            if (!identityResult.Succeeded)
            {
                return Problem();
            }

            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var domainName = HttpContext.Request.Host.Value;
            var confirmEmailReq = new ConfirmEmailRequest { Email = req.Email, Code = token };
            var actionUri = Url.Action(nameof(ConfirmEmail), confirmEmailReq);
            var confirmationLink = $"https://{domainName}{actionUri}";
            await _emailSender.SendConfirmationLinkAsync(user, user.Email, confirmationLink);

            return Ok(ResponseObject.Succeeded);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest req)
        {
            var user = await _userManager.FindByEmailAsync(req.Email);
            if (user is null)
            {
                return Problem(statusCode: StatusCodes.Status400BadRequest, detail: "Not exist user");
            }
            // Use cookies await _signInManager.CheckPasswordSignInAsync(user, req.Password, req.RememberLogin); 
            // Use token    
            var isMatch = await _userManager.CheckPasswordAsync(user, req.Password);
            if (!isMatch)
            {
                return Problem(statusCode: StatusCodes.Status400BadRequest, detail: "Password incorrect");
            }

            var claims = new List<Claim>
            {
                new (ClaimTypes.Sid, user.Id),
                new (ClaimTypes.Email, user.Email!),
            };
            var roles = await _userManager.GetRolesAsync(user);
            claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));

            var accessToken = _tokenService.GenerateAccessToken(claims);
            var refreshToken = _tokenService.GenerateRefreshToken();
            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(_jwtConfig.RefreshTokenExpiryTime); // Expiry time refresh token
            var identityResult = await _userManager.UpdateAsync(user); // Save refresh token in Db
            if (!identityResult.Succeeded)
            {
                return Problem();
            }
            SetTokenInCookie(accessToken, refreshToken);
            return Ok(ResponseObject.Succeeded);
        }

        [HttpPost("refreshToken")]
        public async Task<IActionResult> RefreshToken()
        {
            this.HttpContext.Request.Cookies.TryGetValue("refresh-token", out var refreshToken);

            var user = await _userManager.Users
                .SingleOrDefaultAsync(u => u.RefreshToken == refreshToken);

            if (user is null)
            {
                return Problem(statusCode: StatusCodes.Status401Unauthorized, detail: "Not exist user");
            }

            if (user.RefreshTokenExpiryTime is null || user.RefreshTokenExpiryTime < DateTime.UtcNow)
            {
                return Problem(statusCode: StatusCodes.Status401Unauthorized, detail: "Invalid Refresh Token");
            }

            var claims = new List<Claim>
            {
                new (ClaimTypes.Sid, user.Id),
                new (ClaimTypes.Email, user.Email!),
            };
            var roles = await _userManager.GetRolesAsync(user);
            claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));

            var newAccessToken = _tokenService.GenerateAccessToken(claims);
            var newRefreshToken = _tokenService.GenerateRefreshToken();
            user.RefreshToken = newRefreshToken;
            user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(_jwtConfig.RefreshTokenExpiryTime); // Expiry time refresh token
            var identityResult = await _userManager.UpdateAsync(user); // Save refresh token in Db
            if (!identityResult.Succeeded)
            {
                return Problem();
            }
            SetTokenInCookie(newAccessToken, newRefreshToken);
            return Ok(ResponseObject.Succeeded);
        }

        [HttpPost("resendConfirmEmail")]
        public async Task<IActionResult> ResendConfirmEmail(ResendConfirmEmailRequest req)
        {
            var user = await _userManager.FindByEmailAsync(req.Email);

            if (user is null)
            {
                return Problem(statusCode: StatusCodes.Status400BadRequest, detail: "Not found user");
            }
            if (await _userManager.IsEmailConfirmedAsync(user))
            {
                return Problem(statusCode: StatusCodes.Status400BadRequest, detail: "Email confirmed");
            }

            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var domainName = HttpContext.Request.Host.Value;
            var confirmEmailReq = new ConfirmEmailRequest { Email = req.Email, Code = token };
            var actionUri = Url.Action(nameof(ConfirmEmail), confirmEmailReq);
            var confirmationLink = $"https://{domainName}{actionUri}";
            await _emailSender.SendConfirmationLinkAsync(user, req.Email, confirmationLink);
            return Ok(ResponseObject.Succeeded);
        }

        [HttpPost("forgotPassword")]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordRequest req)
        {
            var user = await _userManager.FindByEmailAsync(req.Email);
            if (user is null)
            {
                return Problem(statusCode: StatusCodes.Status400BadRequest, detail: "Not found user");
            }

            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            await _emailSender.SendPasswordResetCodeAsync(user, req.Email, code);

            return Ok(ResponseObject.Succeeded);
        }

        [HttpPost("resetPassword")]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequest req)
        {
            var user = await _userManager.FindByEmailAsync(req.Email);
            if (user is null)
            {
                return Problem(statusCode: StatusCodes.Status400BadRequest, detail: "Not found user");
            }
            var resetCode = await _userManager.GeneratePasswordResetTokenAsync(user);
            var identityResult = await _userManager.ResetPasswordAsync(user, resetCode, req.NewPassword);

            if (!identityResult.Succeeded)
            {
                var errors = identityResult.Errors.Select(e => e.Description);
                return Problem(errors.First());
            }

            return Ok(ResponseObject.Succeeded);
        }

        [Authorize]
        [HttpPost("changePassword")]
        public async Task<IActionResult> ChangePassword(ChangePasswordRequest req)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.Sid);
            var user = await _userManager.FindByIdAsync(userId!);
            if (user is null)
            {
                return Problem(statusCode: StatusCodes.Status401Unauthorized);
            }

            var identityResult = await _userManager.ChangePasswordAsync(user, req.OldPassword, req.NewPassword);
            if (!identityResult.Succeeded)
            {
                var errors = identityResult.Errors.Select(e => e.Description);
                return Problem(errors.First());
            }

            return Ok(ResponseObject.Succeeded);
        }

        private void SetTokenInCookie(string accessToken, string refreshToken)
        {
            var cookieOptionsForAccessToken = new CookieOptions()
            {
                HttpOnly = true, // XSS
                Secure = true, // Https
                Expires = DateTime.UtcNow.AddMinutes(_jwtConfig.Expires), // Expiration
                SameSite = SameSiteMode.Strict, // CSRF
            };
            this.HttpContext.Response.Cookies.Append("access-token", accessToken, cookieOptionsForAccessToken);

            var cookieOptionsForRefreshToken = new CookieOptions()
            {
                HttpOnly = true, // XSS
                Secure = true, // Https
                Expires = DateTime.UtcNow.AddDays(_jwtConfig.RefreshTokenExpiryTime), // Expiration
                SameSite = SameSiteMode.Strict, // CSRF
                Path = "/api/v1/refreshToken",
                Domain = "localhost"
            };
            this.HttpContext.Response.Cookies.Append("refresh-token", refreshToken, cookieOptionsForRefreshToken);
        }
    }
}
