using EShop.Application.Entities;

namespace EShop.Application.Services
{
    public interface IEmailSenderService
    {
        Task SendConfirmationLinkAsync(User user, string email, string confirmationLink);

        Task SendPasswordResetLinkAsync(User user, string email, string resetLink);

        Task SendPasswordResetCodeAsync(User user, string email, string resetCode);
    }
}