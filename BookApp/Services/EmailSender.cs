using Microsoft.AspNetCore.Identity.UI.Services;
using NuGet.Protocol;

namespace BookApp.Services

{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Task.CompletedTask;
        }
    }
}
