
using EShop.Application.Services.Interfaces;
using EShop.Shared.RequestModels.Identity;
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

            if (resultService.Succeeded)
            {
                return Ok();
            }
            return Problem(resultService.Errors.First());
        }


        //[HttpGet]
        //public IActionResult ManageInfo()
        //{
        //    return Ok();
        //}

        #endregion

        #region Post method

        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequest req)
        {
            var resultService = await _identityService.Register(req.Email, req.Email, req.Password);

            if (!resultService.Succeeded)
            {
                return Problem(resultService.Errors.First());
            }

            var token = await _identityService.GenerateEmailConfirmationToken(req.Email);
            var domainName = HttpContext.Request.Host.Value;
            var actionUri = Url.Action(
                nameof(ConfirmEmail),
                new ConfirmEmailRequest { Email = req.Email, Code = token });
            var confirmationLink = $"https://{domainName}{actionUri}";
            var resultEmailService = await _emailSenderService.SendConfirmationLinkAsync(req.Email, req.Email, confirmationLink);

            if (!resultEmailService.Succeeded)
            {
                return Problem(resultEmailService.Errors.First());
            }

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInRequest req)
        {
            var resultService = await _identityService.SignIn(req.Email, req.Password, false);
            if (resultService.Succeeded)
            {
                var token = await _identityService.GenerateJwtToken(req.Email);

                var cookieOptions = new CookieOptions()
                {
                    HttpOnly = true, // XSS
                    Secure = true,
                    Expires = DateTime.UtcNow.AddDays(1), // Expiration
                    SameSite = SameSiteMode.Strict // CSRF
                };

                this.HttpContext.Response.Cookies.Append("jwt", token, cookieOptions);
                return Ok();
            }
            return Problem(resultService.Errors.First());
        }

        //[Authorize]
        //[HttpPost]
        //public IActionResult RefreshToken(RefreshTokenRequest req)
        //{
        //    var token = _identityService.RefreshToken(req.RefreshToken);
        //    var cookieOptions = new CookieOptions()
        //    {
        //        HttpOnly = true, // XSS
        //        Secure = true,
        //        Expires = DateTime.UtcNow.AddDays(1), // Expiration
        //        SameSite = SameSiteMode.Strict // CSRF
        //    };
        //    return Ok();
        //}

        [HttpPost]
        public async Task<IActionResult> ResendConfirmEmail(ResendConfirmEmailRequest req)
        {
            var existUser = await _identityService.CheckExistUserByEmailAsync(req.Email);

            if (existUser)
            {
                var token = await _identityService.GenerateEmailConfirmationToken(req.Email);
                var domainName = HttpContext.Request.Host.Value;
                var actionUri = Url.Action(
                    nameof(ConfirmEmail),
                    new ConfirmEmailRequest { Email = req.Email, Code = token });
                var confirmationLink = $"https://{domainName}{actionUri}";
                await _emailSenderService.SendConfirmationLinkAsync(req.Email, req.Email, confirmationLink);
                return Ok();
            }
            return Problem("Not found user");
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordRequest req)
        {
            var resultService = await _identityService.ForgotPassword(req.Email);

            if (resultService.Succeeded)
            {
                return Ok();
            }
            return Problem(resultService.Errors.First());
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequest req)
        {
            var resultService = await _identityService.ResetPassword(req.Email, req.ResetCode, req.NewPassword);
            if (resultService.Succeeded)
            {
                return Ok();
            }
            return Problem(resultService.Errors.First());
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

        #endregion
    }
}
