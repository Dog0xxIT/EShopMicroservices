using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Identity.Api.Models.RequestModels;
using Identity.Api.Models.ResponseModels;
using Identity.Api.Services.TokenService;
using Microsoft.AspNetCore.Authentication.BearerToken;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Identity.Api.Controllers
{
    [ApiController]
    [Route("/api/v1")]
    public class IdentityController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IEmailSender<IdentityUser> _emailSender;
        private readonly ILogger<IdentityController> _logger;
        private readonly JwtConfig _jwtConfig;
        private readonly ITokenService _tokenService;

        public IdentityController(UserManager<IdentityUser> userManager, IEmailSender<IdentityUser> emailSender, ILogger<IdentityController> logger, IOptions<JwtConfig> jwtOptions,
            SignInManager<IdentityUser> signInManager, ITokenService tokenService)
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

            var roles = await _userManager.GetRolesAsync(user);
            var claims = new List<Claim>
            {
                new("email", req.Email),
                new("roles", string.Join(',', roles))
            };

            var accessToken = _tokenService.GenerateAccessToken(claims);
            var refreshToken = await _userManager.GenerateUserTokenAsync(user, "EShop.Identity", "RefreshToken");

            // Save RefreshToken
            await _userManager.SetAuthenticationTokenAsync(user, "EShop.Identity", "RefreshToken", refreshToken);

            ConfigTokenInCookie(accessToken, refreshToken);

            return Ok(ResponseObject.Succeeded);
        }

        [Authorize(AuthenticationSchemes = BearerTokenDefaults.AuthenticationScheme)]
        [HttpPost("refreshToken")]
        public async Task<IActionResult> RefreshToken(string accessToken)
        {
            var principal = _tokenService.GetPrincipalFromExpiredToken(accessToken);
            var email = principal.Claims.SingleOrDefault(c => c.Type == "email")?.Value;

            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(accessToken);

            if (jwtSecurityToken is null)
            {
                return Unauthorized();
            }

            if (string.IsNullOrEmpty(email))
            {
                return Unauthorized();
            }

            var user = await _userManager.FindByEmailAsync(email);
            if (user is null)
            {
                return Unauthorized();
            }

            if (refreshToken != await _userManager.GetAuthenticationTokenAsync(user, "EShop.Identity", "RefreshToken"))
            {
                return Unauthorized();
            }

            var newAccessToken = _tokenService.GenerateAccessToken(jwtSecurityToken.Claims);
            var newRefreshToken = _tokenService.GenerateRefreshToken();

            // Save RefreshToken
            await _userManager.SetAuthenticationTokenAsync(user, "EShop.Identity", "RefreshToken", refreshToken);

            var cookieOptionsForAccessToken = new CookieOptions()
            {
                HttpOnly = true, // XSS
                Secure = true, // Https
                Expires = DateTime.UtcNow.AddMinutes(1), // Expiration
                SameSite = SameSiteMode.Strict, // CSRF
            };
            this.HttpContext.Response.Cookies.Append("access-token", newAccessToken, cookieOptionsForAccessToken);

            var cookieOptionsForRefreshToken = new CookieOptions()
            {
                HttpOnly = true, // XSS
                Secure = true, // Https
                Expires = DateTime.UtcNow.AddMinutes(1), // Expiration
                SameSite = SameSiteMode.Strict, // CSRF
            };
            this.HttpContext.Response.Cookies.Append("refresh-token", newRefreshToken, cookieOptionsForRefreshToken);

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

        private void ConfigTokenInCookie(string accessToken, string refreshToken)
        {
            var cookieOptionsForAccessToken = new CookieOptions()
            {
                HttpOnly = true, // XSS
                Secure = true, // Https
                Expires = DateTime.UtcNow.AddMinutes(30), // Expiration
                SameSite = SameSiteMode.Strict, // CSRF
            };
            this.HttpContext.Response.Cookies.Append("access-token", accessToken, cookieOptionsForAccessToken);

            var cookieOptionsForRefreshToken = new CookieOptions()
            {
                HttpOnly = true, // XSS
                Secure = true, // Https
                Expires = DateTime.UtcNow.AddDays(3), // Expiration
                SameSite = SameSiteMode.Strict, // CSRF
                Path = "/refresh-token"
            };
            this.HttpContext.Response.Cookies.Append("refresh-token", refreshToken, cookieOptionsForRefreshToken);
        }
    }
}
