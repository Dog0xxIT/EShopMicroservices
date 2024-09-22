using EShop.Shared.RequestModels.Identity;
using Newtonsoft.Json.Linq;

namespace EShop.Api.Controllers
{
    [ApiController]
    [Route("")]
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
        [HttpGet("confirmEmail")]
        public async Task<IActionResult> ConfirmEmail([FromQuery] ConfirmEmailRequest req)
        {
            var resultService = await _identityService.ConfirmEmail(req.Email, req.Code);

            if (resultService.Succeeded)
            {
                return Ok(ResponseObject.Succeeded);
            }
            return Problem(resultService.Errors.First());
        }

        [HttpGet("manageInfo")]
        [Authorize]
        public async Task<IActionResult> ManageInfo()
        {
            var jwtToken = HttpContext.Request.Cookies["jwt"]!;
            var resultService = await _identityService.ManageInfo(jwtToken);
            return Ok(resultService);
        }

        [HttpGet("logout")]
        [Authorize]
        public async Task<IActionResult> SignOut()
        {
            this.HttpContext.Response.Cookies.Delete("jwt");
            return Ok(ResponseObject.Succeeded);
        }

        #endregion

        #region Post method

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest req)
        {
            var resultService = await _identityService.Register(req.Email, req.Email, req.Password);

            if (!resultService.Succeeded)
            {
                return Problem(resultService.Errors.First());
            }

            var token = await _identityService.GenerateEmailConfirmationToken(req.Email);
            var domainName = HttpContext.Request.Host.Value;
            var actionUri = Url.Action(nameof(ConfirmEmail),
                new ConfirmEmailRequest { Email = req.Email, Code = token });
            var confirmationLink = $"https://{domainName}{actionUri}";
            var resultEmailService = await _emailSenderService.SendConfirmationLinkAsync(req.Email, req.Email, confirmationLink);

            if (!resultEmailService.Succeeded)
            {
                return Problem(resultEmailService.Errors.First());
            }

            return Ok(ResponseObject.Succeeded);
        }

        [HttpPost("login")]
        public async Task<IActionResult> SignIn(SignInRequest req)
        {
            var resultService = await _identityService.SignIn(req.Email, req.Password, false);
            if (resultService.Succeeded)
            {
                var token = await _identityService.GenerateJwtToken(req.Email);

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
            return Problem(resultService.Errors.First());
        }

        [Authorize]
        [HttpPost("refreshToken")]
        public async Task<IActionResult> RefreshToken()
        {
            var oldToken = HttpContext.Request.Cookies["jwt"]!;
            var newToken = await _identityService.RefreshToken(oldToken);
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

        [HttpPost("forgotPassword")]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordRequest req)
        {
            var resultService = await _identityService.ForgotPassword(req.Email);

            if (resultService.Succeeded)
            {
                return Ok(ResponseObject.Succeeded);
            }
            return Problem(resultService.Errors.First());
        }

        [HttpPost("resetPassword")]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequest req)
        {
            var resultService = await _identityService.ResetPassword(req.Email, req.ResetCode, req.NewPassword);
            if (resultService.Succeeded)
            {
                return Ok(ResponseObject.Succeeded);
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
