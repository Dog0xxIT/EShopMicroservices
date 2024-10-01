using Microsoft.AspNetCore.Components;
using WebApp.Models.RequestModels.Identity;

namespace WebApp.Pages.User;

public partial class ResetPassword
{
    [CascadingParameter(Name = "Notification")]
    private TelerikNotification _notificatioRef { get; set; }

    private ResetPasswordRequest _resetPasswordRequest;

    protected override void OnInitialized()
    {
        _resetPasswordRequest = new();
    }

    private async Task ValidSubmit()
    {
        var resultObject = await IdentityService.ResetPassword(_resetPasswordRequest);
        if (resultObject.ResultCode.Equals(ResultCode.Success))
        {
            _notificatioRef.Show(
                text: resultObject.Messages,
                themeColor: ThemeConstants.Notification.ThemeColor.Light);
            NavigationManager.NavigateTo("/");
            return;
        }

        _notificatioRef.Show(
            text: resultObject.Messages,
            themeColor: ThemeConstants.Notification.ThemeColor.Error);
    }
}