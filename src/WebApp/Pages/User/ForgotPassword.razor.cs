using Microsoft.AspNetCore.Components;
using WebApp.Models.RequestModels.Identity;

namespace WebApp.Pages.User;

public partial class ForgotPassword
{
    [CascadingParameter(Name = "Notification")]
    private TelerikNotification _notificatioRef { get; set; }

    private ForgotPasswordRequest _forgotPasswordRequest;

    protected override void OnInitialized()
    {
        _forgotPasswordRequest = new();
    }

    private async Task ValidSubmit()
    {
        var resultObject = await IdentityService.ForgotPassword(_forgotPasswordRequest);
        if (resultObject.ResultCode.Equals(ResultCode.Success))
        {
            _notificatioRef.Show(
                text: "Please check email",
                themeColor: ThemeConstants.Notification.ThemeColor.Light);
            NavigationManager.NavigateTo("/");
            return;
        }

        _notificatioRef.Show(
            text: resultObject.Messages,
            themeColor: ThemeConstants.Notification.ThemeColor.Error);
    }
}