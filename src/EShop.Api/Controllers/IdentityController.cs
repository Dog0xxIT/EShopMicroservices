using EShop.Api.Configurations;
using EShop.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using EShop.Api.Services.EmailSenderService;
using EShop.Data.Constants;
using EShop.Shared.RequestModels.Identity;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EShop.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class IdentityController(
        UserManager<User> userManager,
        ILogger<IdentityController> logger,
        SignInManager<User> signInManager,
        JwtConfig jwtConfig,
        IEmailSender emailSender)
        : ControllerBase
    {
        private readonly UserManager<User> _userManager = userManager;
        private readonly SignInManager<User> _signInManager = signInManager;
        private readonly ILogger<IdentityController> _logger = logger;
        private readonly JwtConfig _jwtConfig = jwtConfig;
        private readonly IEmailSender _emailSender = emailSender;

        #region Get method

        [HttpGet]
        public async Task<IActionResult> ConfirmEmail([FromQuery] ConfirmEmailRequest req)
        {
            var userEntity = await _userManager.FindByEmailAsync(req.Email);
            if (userEntity is null)
            {
                return NotFound("Not found user");
            }

            var identityResult = await _userManager.ConfirmEmailAsync(userEntity, req.Code);

            if (identityResult.Errors.Any())
            {
                var errors = string.Join(' ', identityResult.Errors.Select(e => e.Description));
                return Problem(errors);
            }
            return Ok();
        }


        [HttpGet]
        public IActionResult ManageInfo()
        {
            return Ok();
        }

        #endregion

        #region Post method

        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequest req)
        {
            var userEntity = new User
            {
                UserName = req.Email,
                Email = req.Email,
            };

            var identityResult = await _userManager.CreateAsync(userEntity, req.Password);
            if (identityResult.Errors.Any())
            {
                var errors = string.Join(' ', identityResult.Errors.Select(e => e.Description));
                return Problem(errors);
            }

            identityResult = await _userManager.AddToRoleAsync(userEntity, RolesConstant.Customer);
            if (identityResult.Errors.Any())
            {
                var errors = string.Join(' ', identityResult.Errors.Select(e => e.Description));
                return Problem(errors);
            }

            var token = await _userManager.GenerateEmailConfirmationTokenAsync(userEntity);
            var domainName = HttpContext.Request.Host.Value;
            var actionUri = Url.Action(nameof(ConfirmEmail), new ConfirmEmailRequest { Email = req.Email, Code = token });
            var confirmationLink = $"https://{domainName}{actionUri}";
            await _emailSender.SendConfirmationLinkAsync(userEntity, userEntity.Email, confirmationLink);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInRequest req)
        {
            var signInResult = await _signInManager.PasswordSignInAsync(req.Email, req.Password, true, false);

            if (!signInResult.Succeeded)
            {
                var errorsJson = JsonConvert.SerializeObject(signInResult);
                return Problem(errorsJson);
            }

            var user = await _userManager.FindByEmailAsync(req.Email);
            var roles = await _userManager.GetRolesAsync(user!);
            var claims = new List<Claim>
            {
                new("email", req.Email),
                new("roles", string.Join(',', roles))
            };
            var token = GenerateJwtToken(claims);

            return Ok(token);
        }

        [Authorize]
        [HttpPost]
        public IActionResult RefreshToken(RefreshTokenRequest req)
        {
            var jwtToken = new JwtSecurityToken(req.RefreshToken);
            var claims = jwtToken.Claims.ToList();
            var token = GenerateJwtToken(claims);
            return Ok(token);
        }


        [HttpPost]
        public async Task<IActionResult> ResendConfirmEmail(ResendConfirmEmailRequest req)
        {
            var userEntity = await _userManager.FindByEmailAsync(req.Email);
            if (userEntity == null)
            {
                return BadRequest("Not found user");
            }

            var token = await _userManager.GenerateEmailConfirmationTokenAsync(userEntity);
            var domainName = HttpContext.Request.Host.Value;
            var actionUri = Url.Action(nameof(ConfirmEmail), new ConfirmEmailRequest { Email = req.Email, Code = token });
            var confirmationLink = $"https://{domainName}{actionUri}";
            await _emailSender.SendConfirmationLinkAsync(userEntity, req.Email, confirmationLink);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordRequest req)
        {
            var userEntity = await _userManager.FindByEmailAsync(req.Email);
            if (userEntity == null)
            {
                return BadRequest("Not found user");
            }

            var code = await _userManager.GeneratePasswordResetTokenAsync(userEntity);
            await _emailSender.SendPasswordResetCodeAsync(userEntity, req.Email, code);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequest req)
        {
            var userEntity = await _userManager.FindByEmailAsync(req.Email);
            if (userEntity == null)
            {
                return BadRequest("Not found user");
            }

            var identityResult = await _userManager.ResetPasswordAsync(userEntity, req.ResetCode, req.NewPassword);
            if (identityResult.Errors.Any())
            {
                return Problem(identityResult.Errors.First().Description);
            }
            return Ok();
        }

        [HttpPost]
        public IActionResult Manage2Fa(Manage2FaRequest req)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult ManageInfo(ManageInfoRequest req)
        {
            return Ok();
        }

        #endregion

        private string GenerateJwtToken(List<Claim> claims)
        {
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
            return jwtSecurityTokenHandler.WriteToken(new JwtSecurityToken(header, payload));
        }
    }
}
