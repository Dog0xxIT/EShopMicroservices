using EShop.Application.Services.Interfaces;
using EShop.Infrastructure.Services;
using EShop.Shared.RequestModels.Identity;
using EShop.Shared.ResponseModels;
using EShop.Shared.ResponseModels.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class IdentityController : ControllerBase
    {
        private readonly IIdentityService _identityService;
        private readonly IEmailSenderService _emailSenderService;
        private readonly ILogger<IdentityController> _logger;

        public IdentityController(IIdentityService identityService, IEmailSenderService emailSenderService, ILogger<IdentityController> logger)
        {
            _identityService = identityService;
            _emailSenderService = emailSenderService;
            _logger = logger;
        }

        #region Get method

        [HttpGet]
        public async Task<IActionResult> ConfirmEmail([FromQuery] ConfirmEmailRequest req)
        {
            var resultService = await _identityService.ConfirmEmail(req.Email, req.Code);

            if (resultService.Success)
            {
                return Ok(new SuccessObjectResponse());
            }
            return Problem(resultService.MessageError);
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
            var resultService = await _identityService.Register(req.Email, req.Email, req.Password);

            if (resultService.Success)
            {
                return Ok(new SuccessObjectResponse());
            }
            return Problem(resultService.MessageError);
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInRequest req)
        {
            var resultService = await _identityService.SignIn(req.Email, req.Password, false);
            if (resultService.Success)
            {
                var cookieOptions = new CookieOptions()
                {
                    HttpOnly = true, // XSS
                    Secure = true,
                    Expires = DateTime.UtcNow.AddDays(1), // Expiration
                    SameSite = SameSiteMode.Strict // CSRF
                };

                this.HttpContext.Response.Cookies.Append("jwt", resultService.Data, cookieOptions);
                return Ok(new SuccessObjectResponse());
            }
            return Problem(resultService.MessageError);
        }

        [Authorize]
        [HttpPost]
        public IActionResult RefreshToken(RefreshTokenRequest req)
        {
            var resultService = _identityService.RefreshToken(req.RefreshToken);

            if (resultService.Success)
            {
                var response = new TokenResponse { Token = resultService.Data };
                return Ok(response);
            }
            return Problem(resultService.MessageError);
        }


        [HttpPost]
        public async Task<IActionResult> ResendConfirmEmail(ResendConfirmEmailRequest req)
        {
            var existUser = await _identityService.CheckExistUserByEmailAsync(req.Email);

            if (existUser)
            {
                var token = await _identityService.GenerateEmailConfirmationToken(req.Email);
                var domainName = HttpContext.Request.Host.Value;
                var actionUri = Url.Action(nameof(ConfirmEmail), new ConfirmEmailRequest { Email = req.Email, Code = token });
                var confirmationLink = $"https://{domainName}{actionUri}";
                await _emailSenderService.SendConfirmationLinkAsync(req.Email, req.Email, confirmationLink);
                return Ok(new SuccessObjectResponse());
            }
            return Problem("Not found user");
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordRequest req)
        {
            var resultService = await _identityService.ForgotPassword(req.Email);

            if (resultService.Success)
            {
                return Ok(new SuccessObjectResponse());
            }
            return Problem(resultService.MessageError);
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequest req)
        {
            var resultService = await _identityService.ResetPassword(req.Email, req.ResetCode, req.NewPassword);
            if (resultService.Success)
            {
                return Ok(new SuccessObjectResponse());
            }
            return Problem(resultService.MessageError);
        }

        [HttpPost]
        public IActionResult Manage2Fa(Manage2FaRequest req)
        {
            return Ok(new SuccessObjectResponse());
        }

        [HttpPost]
        public IActionResult ManageInfo(ManageInfoRequest req)
        {
            return Ok(new SuccessObjectResponse());
        }

        #endregion
    }
}
