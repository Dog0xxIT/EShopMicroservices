using Microsoft.AspNetCore.Components;
using WebApp.Models.RequestModels.Identity;

namespace WebApp.Pages.User;

public partial class Login
{
    [CascadingParameter(Name = "Notification")]
    private TelerikNotification _notificatioRef { get; set; }

    private SignInRequest _signInRequest;

    protected override void OnInitialized()
    {
        _signInRequest = new();
        // Check uri for redirect page
        if (_nav.Uri != $"{_nav.BaseUri}login")
        {
            _nav.NavigateTo("/login");
        }
    }

    private async Task ValidSubmit()
    {
        var resultObject = await _accountManagement.Login(_signInRequest);
        if (resultObject.ResultCode.Equals(ResultCode.Success))
        {
            _notificatioRef.Show(
                text: resultObject.Messages,
                themeColor: ThemeConstants.Notification.ThemeColor.Light);
            _nav.NavigateTo("/");
            return;
        }

        _notificatioRef.Show(
            text: resultObject.Messages,
            themeColor: ThemeConstants.Notification.ThemeColor.Error);
    }
}