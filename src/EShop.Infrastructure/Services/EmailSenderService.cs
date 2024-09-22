using EShop.Application.Configurations;
using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;

namespace EShop.Infrastructure.Services
{
    public class EmailSenderService : IEmailSenderService
    {
        private readonly ILogger<EmailSenderService> _logger;
        private readonly SmtpConfig _smtpConfig;

        public EmailSenderService(ILogger<EmailSenderService> logger, SmtpConfig smtpConfig)
        {
            _logger = logger;
            _smtpConfig = smtpConfig;
        }

        public async Task<ServiceResult> SendConfirmationLinkAsync(string userName, string email, string confirmationLink)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(_smtpConfig.UserName, _smtpConfig.Host));
            message.To.Add(new MailboxAddress(userName, email));
            message.Subject = "Confirm your email";
            message.Body = new TextPart(TextFormat.Html)
            {
                Text = $"Please confirm your account by <a href='{confirmationLink}'>clicking here</a>.",
            };

            return await SendAsync(message);
        }


        public async Task<ServiceResult> SendPasswordResetLinkAsync(string userName, string email, string resetLink)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(_smtpConfig.UserName, _smtpConfig.Host));
            message.To.Add(new MailboxAddress(userName, email));
            message.Subject = "Reset your password";
            message.Body = new TextPart(TextFormat.Html)
            {
                Text = $"Please reset your password by <a href='{resetLink}'>clicking here</a>.",
            };

            return await SendAsync(message);
        }


        public async Task<ServiceResult> SendPasswordResetCodeAsync(string userName, string email, string resetCode)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(_smtpConfig.UserName, _smtpConfig.Host));
            message.To.Add(new MailboxAddress(userName, email));
            message.Subject = "Reset your password";
            message.Body = new TextPart(TextFormat.Html)
            {
                Text = $"Please reset your password using the following code: {resetCode}",
            };
            return await SendAsync(message);
        }

        public async Task<ServiceResult> SendAsync(MimeMessage message)
        {
            using (var client = new SmtpClient())
            {
                try
                {
                    await client.ConnectAsync(_smtpConfig.Host, _smtpConfig.Port, true);
                    await client.AuthenticateAsync(_smtpConfig.UserName, _smtpConfig.Password);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    await client.SendAsync(message);
                    return ServiceResult.Success;
                }
                catch (Exception ex)
                {
                    return ServiceResult.Failed(ex.Message);
                }
                finally
                {
                    await client.DisconnectAsync(true);

                }
            }
        }
    }
}