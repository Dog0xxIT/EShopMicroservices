using Microsoft.AspNetCore.Components;
using WebApp.Models.RequestModels.Identity;

namespace WebApp.Pages.User;

public partial class Register
{
    [CascadingParameter(Name = "Notification")]
    private TelerikNotification _notificatioRef { get; set; }

    private RegisterRequest _registerRequest;

    protected override void OnInitialized()
    {
        _registerRequest = new();
    }

    private async Task ValidSubmit()
    {
        var resultObject = await _identityService.Register(_registerRequest);

        if (resultObject.ResultCode.Equals(ResultCode.Success))
        {
            _notificatioRef.Show(
                text: resultObject.Messages,
                themeColor: ThemeConstants.Notification.ThemeColor.Light);
            _navManager.NavigateTo("sign-in");
            return;
        }

        _notificatioRef.Show(
            text: resultObject.Messages,
            themeColor: ThemeConstants.Notification.ThemeColor.Error);
    }
}