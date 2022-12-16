using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;
using TheSkyHomestay.Application.IServices;
using TheSkyHomestay.DTO.Email;
using MailKit.Net.Smtp;

namespace TheSkyHomestay.Application.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;

        public EmailService(IConfiguration config)
        {
            _config = config;
        }

        public void SendEmail(SendEmailDTO request)
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("The Sky Homestay Hòn Sơn", _config.GetSection("SkyEmailAddress").Value));
            email.To.Add(MailboxAddress.Parse(request.To));
            email.Subject = request.Subject;

            var builder = new BodyBuilder();
            builder.HtmlBody = request.Body;
            email.Body = builder.ToMessageBody();

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect(_config.GetSection("EmailHost").Value, 587, SecureSocketOptions.StartTls);
            smtpClient.Authenticate(_config.GetSection("SkyEmailAddress").Value, _config.GetSection("SkyEmailPassword").Value);
            smtpClient.Send(email);
            smtpClient.Disconnect(true);
        }

        public void SendEmailFromGuest(SendEmailDTO request)
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("Du khách", _config.GetSection("GuestEmailAddress").Value));
            email.To.Add(MailboxAddress.Parse(request.To));
            email.Subject = request.Subject;

            var builder = new BodyBuilder();
            builder.HtmlBody = request.Body;
            email.Body = builder.ToMessageBody();

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect(_config.GetSection("EmailHost").Value, 587, SecureSocketOptions.StartTls);
            smtpClient.Authenticate(_config.GetSection("GuestEmailAddress").Value, _config.GetSection("GuestEmailPassword").Value);
            smtpClient.Send(email);
            smtpClient.Disconnect(true);
        }
    }
}
