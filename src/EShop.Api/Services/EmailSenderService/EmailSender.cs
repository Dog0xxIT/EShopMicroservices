using EShop.Api.Configurations;
using EShop.Data.Entities;
using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;

namespace EShop.Api.Services.EmailSenderService
{
    public class EmailSender : IEmailSender
    {
        private readonly ILogger<EmailSender> _logger;
        private readonly SmtpConfig _smtpConfig;

        public EmailSender(ILogger<EmailSender> logger, SmtpConfig smtpConfig)
        {
            _logger = logger;
            _smtpConfig = smtpConfig;
        }

        public async Task SendConfirmationLinkAsync(User user, string email, string confirmationLink)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(_smtpConfig.UserName, _smtpConfig.Host));
            message.To.Add(new MailboxAddress(user.UserName, email));
            message.Subject = "Confirm your email";
            message.Body = new TextPart(TextFormat.Html)
            {
                Text = $"Please confirm your account by <a href='{confirmationLink}'>clicking here</a>.",
            };

            await SendAsync(message);
        }


        public async Task SendPasswordResetLinkAsync(User user, string email, string resetLink)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(_smtpConfig.UserName, _smtpConfig.Host));
            message.To.Add(new MailboxAddress(user.UserName, email));
            message.Subject = "Reset your password";
            message.Body = new TextPart(TextFormat.Html)
            {
                Text = $"Please reset your password by <a href='{resetLink}'>clicking here</a>.",
            };

            await SendAsync(message);
        }


        public async Task SendPasswordResetCodeAsync(User user, string email, string resetCode)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(_smtpConfig.UserName, _smtpConfig.Host));
            message.To.Add(new MailboxAddress(user.UserName, email));
            message.Subject = "Reset your password";
            message.Body = new TextPart(TextFormat.Html)
            {
                Text = $"Please reset your password using the following code: {resetCode}",
            };

            await SendAsync(message);
        }

        public async Task SendAsync(MimeMessage message)
        {
            using (var client = new SmtpClient())
            {
                try
                {
                    await client.ConnectAsync(_smtpConfig.Host, _smtpConfig.Port, true);
                    await client.AuthenticateAsync(_smtpConfig.UserName, _smtpConfig.Password);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    await client.SendAsync(message);
                }
                finally
                {
                    await client.DisconnectAsync(true);
                }
            }
        }
    }
}