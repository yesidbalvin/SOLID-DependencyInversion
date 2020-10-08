using Microsoft.Extensions.DependencyInjection;
using Solid.BusinessRules;
using Solid.BusinessRules.ServiceExtensions;
using Solid.Infrastructure.ServiceExtensions;
using System;

namespace Solid.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var serviceProvider = new ServiceCollection()
                .AddBusinessRules()
                .AddInfrastructureServices().BuildServiceProvider();

            var notification = serviceProvider.GetRequiredService<INotification>();
            var emailAddress = "email@myemail.com";
            var result = notification.NotifyCreationByEmail(emailAddress);

            if (result)
            {
                Console.WriteLine($"The email was sent to {emailAddress}");
            }
        }
    }
}
