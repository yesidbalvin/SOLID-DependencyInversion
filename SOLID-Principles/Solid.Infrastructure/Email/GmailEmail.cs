using Solid.Domain.Email;
using Solid.Domain.EmailData;

namespace Solid.Infrastructure.Email
{
    public class GmailEmail : IEmailService
    {
        public GmailEmail()
        {
            //do something to instantiate mail provider
        }
        public bool SendEmail(EmailData emailData)
        {
            return true;
        }
    }
}
