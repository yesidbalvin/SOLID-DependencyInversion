using Microsoft.Extensions.DependencyInjection;
using Solid.Domain.Email;
using Solid.Infrastructure.Email;

namespace Solid.Infrastructure.ServiceExtensions
{
    public static class ConfigureServiceExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services) =>
            services.AddSingleton<IEmailService, GmailEmail>();
    }
}
