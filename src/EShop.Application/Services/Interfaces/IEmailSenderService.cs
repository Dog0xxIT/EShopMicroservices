using EShop.Application.Dto;
using EShop.Application.Entities;

namespace EShop.Application.Services.Interfaces
{
    public interface IEmailSenderService
    {
        Task<ServiceResult> SendConfirmationLinkAsync(string userName, string email, string confirmationLink);
        Task<ServiceResult> SendPasswordResetLinkAsync(string userName, string email, string resetLink);
        Task<ServiceResult> SendPasswordResetCodeAsync(string userName, string email, string resetCode);
    }
}