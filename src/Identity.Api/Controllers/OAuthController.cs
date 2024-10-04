using Microsoft.AspNetCore.Mvc;

namespace Identity.Api.Controllers;

[ApiController]
[Route("")]
public class OAuthController : Controller
{
    private readonly UserManager<User> _userManager;
    private readonly IEmailSender<User> _emailSender;
    private readonly ILogger<OAuthController> _logger;
    private readonly JwtConfig _jwtConfig;
    private readonly SignInManager<User> _signInManager;

    public OAuthController(
        UserManager<User> userManager,
        IEmailSender<User> emailSender,
        ILogger<OAuthController> logger,
        IOptions<JwtConfig> jwtOptions,
        SignInManager<User> signInManager)
    {
        _userManager = userManager;
        _emailSender = emailSender;
        _logger = logger;
        _signInManager = signInManager;
        _jwtConfig = jwtOptions.Value;
    }

    [HttpPost]
    [Route("externalLogin")]
    public async Task<IActionResult> ExternalLogin(string provider, string returnUrl)
    {
        var authSchemes = await _signInManager.GetExternalAuthenticationSchemesAsync();
        if (authSchemes.All(s => s.Name != provider))
        {
            return Problem(statusCode: StatusCodes.Status400BadRequest, detail: "Provider Invalid");
        }

        var domainName = HttpContext.Request.Host.Value;
        var redirectUrl = $"{domainName}/signin-google?{returnUrl}";
        var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
        //properties.AllowRefresh = true;
        return Challenge(properties, provider);
    }

    [HttpGet]
    [Route("signin-google")]
    public async Task<IActionResult> ExternalLoginCallback(string? returnUrl = null)
    {
        var info = await _signInManager.GetExternalLoginInfoAsync();
        if (info is null)
        {
            return Problem("External Login Errors");
        }

        var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, false);
        if (result.IsLockedOut)
        {
            return Problem(statusCode: StatusCodes.Status400BadRequest, detail: "Is Locked Out");
        }
        if (result.IsNotAllowed)
        {
            return Problem(statusCode: StatusCodes.Status400BadRequest, detail: "Is Not Allowed");
        }
        if (!result.Succeeded)
        {
            return Problem("Server Error");
        }

        return Redirect(returnUrl ?? "/");
        //return Ok(ResponseObject.Succeeded);
    }
}