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
        private readonly SignInManager<User> _signInManager;
        private readonly IEmailSender<User> _emailSender;
        private readonly ILogger<IdentityController> _logger;
        private readonly JwtConfig _jwtConfig;
        private readonly ITokenService _tokenService;

        public IdentityController(UserManager<User> userManager, IEmailSender<User> emailSender, ILogger<IdentityController> logger, IOptions<JwtConfig> jwtOptions,
            SignInManager<User> signInManager, ITokenService tokenService)
        {
            _userManager = userManager;
            _emailSender = emailSender;
            _signInManager = signInManager;
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
                return Problem("Not found user");
            }

            var identityResult = await _userManager.ConfirmEmailAsync(user, req.Code);

            if (identityResult.Errors.Any())
            {
                var errors = identityResult.Errors.Select(e => e.Description);
                return Problem(errors.First());
            }

            return Ok(ResponseObject.Succeeded);
        }

        [Authorize]
        [HttpGet("manageInfo")]
        public async Task<IActionResult> ManageInfo()
        {
            var accessToken = HttpContext.Request.Cookies["access-token"]!;

            var jwtSecurityToken = _tokenService.DecodeToken(accessToken);
            var email = jwtSecurityToken.Claims.FirstOrDefault(claim => claim.Type == "email")?.Value;
            var roles = jwtSecurityToken.Claims.FirstOrDefault(claim => claim.Type == "roles")?.Value;
            var userId = jwtSecurityToken.Claims.FirstOrDefault(claim => claim.Type == "userId")?.Value;
            return Ok(new ManageInfoResponse
            {
                Email = email ?? "",
                Roles = roles?.Split(",").ToList() ?? [],
                UserId = userId ?? ""
            });
        }

        [Authorize]
        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            var accessToken = this.HttpContext.Request.Cookies["access-token"]!;
            var jwtSecurityToken = _tokenService.DecodeToken(accessToken);
            var email = jwtSecurityToken.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.Email)?.Value;
            var user = await _userManager.FindByEmailAsync(email ?? "");
            if (user is null)
            {
                return Unauthorized();
            }

            user.RefreshToken = "";
            user.RefreshTokenExpiryTime = DateTime.UtcNow;
            var identityResult = await _userManager.UpdateAsync(user);
            if (!identityResult.Succeeded)
            {
                var errors = identityResult.Errors.Select(i => i.Description);
                return Problem(errors.First());
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
                UserName = req.Email,
                Email = req.Email,
            };

            var identityResult = await _userManager.CreateAsync(user, req.Password);
            if (identityResult.Errors.Any())
            {
                var errors = identityResult.Errors.Select(e => e.Description);
                return Problem(errors.First());
            }

            identityResult = await _userManager.AddToRoleAsync(user, RolesConstant.Customer);
            if (identityResult.Errors.Any())
            {
                var errors = identityResult.Errors.Select(e => e.Description);
                return Problem(errors.First());
            }

            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var domainName = HttpContext.Request.Host.Value;
            var actionUri = Url.Action(nameof(ConfirmEmail),
                new ConfirmEmailRequest { Email = req.Email, Code = token });
            var confirmationLink = $"https://{domainName}{actionUri}";
            await _emailSender.SendConfirmationLinkAsync(user, user.Email, confirmationLink);

            return Ok(ResponseObject.Succeeded);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(SignInRequest req)
        {
            var user = await _userManager.FindByEmailAsync(req.Email);
            if (user is null)
            {
                return Problem("Not exist user");
            }

            var signInResult = await _signInManager.CheckPasswordSignInAsync(user, req.Password, req.RememberLogin);

            if (signInResult.IsNotAllowed)
            {
                return Problem("Confirm your email address");
            }

            if (signInResult.IsLockedOut)
            {
                return Problem("Account locked");
            }

            if (!signInResult.Succeeded)
            {
                return Problem("Password incorrect");
            }

            var roles = await _userManager.GetRolesAsync(user);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, req.Email),
                new Claim(ClaimTypes.Role, RolesConstant.Customer),
            };


            var accessToken = _tokenService.GenerateAccessToken(claims);
            var refreshToken = _tokenService.GenerateRefreshToken();

            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(10); // Expiry time refresh token

            var identityResult = await _userManager.UpdateAsync(user); // Save refresh token in Db
            if (identityResult.Succeeded)
            {
                SetTokenInCookie(accessToken, refreshToken);
                return Ok(ResponseObject.Succeeded);
            }
            return Problem("Server Error");
        }

        [HttpPost("refreshToken")]
        public async Task<IActionResult> RefreshToken()
        {
            this.HttpContext.Request.Cookies.TryGetValue("access-token", out var accessToken);
            this.HttpContext.Request.Cookies.TryGetValue("refresh-token", out var refreshToken);
            if (string.IsNullOrEmpty(accessToken) || string.IsNullOrEmpty(refreshToken))
            {
                return Unauthorized();
            }

            try
            {
                var principal = _tokenService.DecodeToken(accessToken);
                var email = principal.Claims.SingleOrDefault(c => c.Type == ClaimTypes.Email)?.Value ?? "";
                var user = await _userManager.FindByEmailAsync(email);
                if (user is null)
                {
                    return Unauthorized();
                }

                if (user.RefreshToken != refreshToken)
                {
                    return Problem("Invalid Refresh Token");
                }

                if (user.RefreshTokenExpiryTime < DateTime.UtcNow)
                {
                    return Problem("Refresh token timeout. Please login!");
                }

                var newAccessToken = _tokenService.GenerateAccessToken(principal.Claims);
                var newRefreshToken = _tokenService.GenerateRefreshToken();

                user.RefreshToken = newRefreshToken;
                user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(10); // Expiry time refresh token

                var identityResult = await _userManager.UpdateAsync(user); // Save refresh token in Db
                if (identityResult.Succeeded)
                {
                    SetTokenInCookie(newAccessToken, newRefreshToken);
                    return Ok(ResponseObject.Succeeded);
                }
                return Problem("Server Error");
            }
            catch (SecurityTokenException ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPost("resendConfirmEmail")]
        public async Task<IActionResult> ResendConfirmEmail(ResendConfirmEmailRequest req)
        {
            var user = await _userManager.FindByEmailAsync(req.Email);

            if (user != null)
            {
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var domainName = HttpContext.Request.Host.Value;
                var actionUri = Url.Action(
                    nameof(ConfirmEmail),
                    new ConfirmEmailRequest { Email = req.Email, Code = token });
                var confirmationLink = $"https://{domainName}{actionUri}";
                await _emailSender.SendConfirmationLinkAsync(user, req.Email, confirmationLink);
                return Ok();
            }
            return Problem("Not found user");
        }

        [HttpPost("forgotPassword")]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordRequest req)
        {
            var user = await _userManager.FindByEmailAsync(req.Email);
            if (user == null)
            {
                return Problem("Not found user");
            }

            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            await _emailSender.SendPasswordResetCodeAsync(user, req.Email, code);

            return Ok(ResponseObject.Succeeded);
        }

        [HttpPost("resetPassword")]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequest req)
        {
            var user = await _userManager.FindByEmailAsync(req.Email);
            if (user == null)
            {
                return Problem("Not found user");
            }
            var resetCode = await _userManager.GeneratePasswordResetTokenAsync(user);
            var identityResult = await _userManager.ResetPasswordAsync(user, resetCode, req.NewPassword);

            if (identityResult.Errors.Any())
            {
                var errors = identityResult.Errors.Select(e => e.Description);
                return Problem(errors.First());
            }

            return Ok(ResponseObject.Succeeded);
        }

        //[HttpPost]
        //public IActionResult Manage2Fa(Manage2FaRequest req)
        //{
        //    return Ok();
        //}

        //[HttpPost]
        //public IActionResult ManageInfo(ManageInfoRequest req)
        //{
        //    return Ok();
        //}

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
                //Path = "/api/v1/refreshToken"
            };
            this.HttpContext.Response.Cookies.Append("refresh-token", refreshToken, cookieOptionsForRefreshToken);
        }
    }
}
