namespace WebApplication1.Contracts
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}