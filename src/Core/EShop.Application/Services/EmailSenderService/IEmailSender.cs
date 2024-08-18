using EShop.Data.Entities;
using Microsoft.AspNetCore.Identity;
using MimeKit;

namespace EShop.Api.Services.EmailSenderService;

public interface IEmailSender : IEmailSender<User>
{
    Task SendAsync(MimeMessage message);
}