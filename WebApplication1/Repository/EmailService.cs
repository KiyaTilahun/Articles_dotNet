using FluentEmail.Core;
using WebApplication1.Contracts;

namespace WebApplication1.Repository
{
    public class EmailService:IEmailService
    {
        private readonly IFluentEmail _fluentEmail;
        public EmailService(IFluentEmail email)
        {
            _fluentEmail = email;
        }
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            
            await _fluentEmail.To(email).Subject(subject).Body(message).SendAsync();
        }
    }
}