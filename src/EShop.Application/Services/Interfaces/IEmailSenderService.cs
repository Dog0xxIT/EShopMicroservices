using EShop.Application.Entities;

namespace EShop.Application.Services.Interfaces
{
    public interface IEmailSenderService
    {
        Task SendConfirmationLinkAsync(string userName, string email, string confirmationLink);

        Task SendPasswordResetLinkAsync(string userName, string email, string resetLink);

        Task SendPasswordResetCodeAsync(string userName, string email, string resetCode);
    }
}