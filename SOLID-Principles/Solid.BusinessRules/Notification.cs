using Solid.Domain.Email;
using Solid.Domain.EmailData;

namespace Solid.BusinessRules
{
    public class Notification : INotification
    {
        private readonly IEmailService _emailService;
        public Notification(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public bool NotifyCreationByEmail(string emailAddress)
        {
            var emailData = new EmailData
            {
                To = emailAddress,
                Body = "The creation was successful"
            };

            return _emailService.SendEmail(emailData);
        }
    }
}
