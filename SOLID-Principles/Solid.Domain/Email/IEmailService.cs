namespace Solid.Domain.Email
{
    public interface IEmailService
    {
        bool SendEmail(EmailData.EmailData emailData);
    }
}
