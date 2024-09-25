using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Identity.Api.Models.RequestModels;
using Identity.Api.Models.ResponseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Api.Controllers
{
    [ApiController]
    [Route("")]
    public class IdentityController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IEmailSender<IdentityUser> _emailSender;
        private readonly ILogger<IdentityController> _logger;
        private readonly JwtConfig _jwtConfig;

        public IdentityController(UserManager<IdentityUser> userManager, IEmailSender<IdentityUser> emailSender, ILogger<IdentityController> logger, JwtConfig jwtConfig,
            SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _emailSender = emailSender;
            _signInManager = signInManager;
            _logger = logger;
            _jwtConfig = jwtConfig;
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
            var jwtToken = HttpContext.Request.Cookies["jwt"]!;
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(jwtToken);
            if (jwtSecurityToken != null)
            {
                var email = jwtSecurityToken.Claims.FirstOrDefault(claim => claim.Type == "email")?.Value;
                var roles = jwtSecurityToken.Claims.FirstOrDefault(claim => claim.Type == "roles")?.Value;

                return Ok(new ManageInfoResponse
                {
                    Email = email ?? "",
                    Roles = roles?.Split(",").ToList() ?? new(),
                });
            }

            return Challenge();
        }

        [HttpGet("logout")]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            this.HttpContext.Response.Cookies.Delete("jwt");
            return Ok(ResponseObject.Succeeded);
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest req)
        {
            var user = new IdentityUser
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
            var token = await GenerateJwtToken(req.Email);

            var cookieOptions = new CookieOptions()
            {
                HttpOnly = true, // XSS
                Secure = true, // Https
                Expires = DateTime.UtcNow.AddDays(1), // Expiration
                SameSite = SameSiteMode.Strict, // CSRF
            };
            this.HttpContext.Response.Cookies.Append("jwt", token, cookieOptions);
            return Ok(ResponseObject.Succeeded);
        }


        [Authorize]
        [HttpPost("refreshToken")]
        public async Task<IActionResult> RefreshToken()
        {
            var oldToken = HttpContext.Request.Cookies["jwt"]!;
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(oldToken);
            var newToken = "";
            if (jwtSecurityToken != null)
            {
                var email = jwtSecurityToken.Claims.FirstOrDefault(claim => claim.Type == "email")?.Value;
                newToken = await GenerateJwtToken(email ?? string.Empty);
            }
            var cookieOptions = new CookieOptions()
            {
                HttpOnly = true, // XSS
                Secure = true, // Https
                Expires = DateTime.UtcNow.AddDays(1), // Expiration
                SameSite = SameSiteMode.Strict, // CSRF
            };
            this.HttpContext.Response.Cookies.Append("jwt", newToken, cookieOptions);
            return Ok(ResponseObject.Succeeded);
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

        private async Task<string> GenerateJwtToken(string email)
        {
            // Get claims
            var user = await _userManager.FindByEmailAsync(email);
            if (user is null)
            {
                return string.Empty;
            }
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new List<Claim>
            {
                new("email", email),
                new("roles", string.Join(',', roles))
            };

            // GenerateToken
            var signKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfig.SecretKey));
            var signingCredentials = new SigningCredentials(signKey, _jwtConfig.Algorithm);
            var optionsHeader = new Dictionary<string, string>
            {
                ["alg"] = signingCredentials.Algorithm,
                ["typ"] = JwtConstants.TokenType
            };
            var header = new JwtHeader(signingCredentials, optionsHeader);

            var payload = new JwtPayload(
                issuer: _jwtConfig.Issuer,
                audience: _jwtConfig.Audience,
                expires: DateTime.UtcNow.AddDays(Convert.ToInt64(_jwtConfig.Expires)),
                notBefore: DateTime.UtcNow,
                claims: claims);

            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(new JwtSecurityToken(header, payload));

            return token;
        }
    }
}
