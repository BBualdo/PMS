using System.Net.Mail;
using FluentEmail.Core;
using FluentEmail.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;

namespace API.Services;

public class EmailService(IOptions<EmailOptions> options) : IEmailSender
{
    private readonly EmailOptions _options = options.Value;

    public async Task SendEmailAsync(string toEmail, string subject, string message)
    {
        await ExecuteAsync(toEmail, subject, message);
    }

    private async Task ExecuteAsync(string toEmail, string subject, string message)
    {
        var sender = new SmtpSender(() =>
            new SmtpClient(_options.SmtpServer, _options.Port)
            {
                EnableSsl = _options.EnableSsl,
                DeliveryMethod = SmtpDeliveryMethod.Network
                // UseDefaultCredentials = false,
                // Credentials = new NetworkCredential(_options.Sender, _options.Password)
            });

        Email.DefaultSender = sender;

        var email = await Email
            .From(_options.Sender, _options.SenderName)
            .To(toEmail)
            .Subject(subject)
            .Body(message)
            .SendAsync();

        if (!email.Successful)
        {
            // log errors
        }
    }
}