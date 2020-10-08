using Microsoft.Extensions.DependencyInjection;

namespace Solid.BusinessRules.ServiceExtensions
{
    public static class ConfigureServicesExtensions
    {
        public static IServiceCollection AddBusinessRules(this IServiceCollection services)
            => services.AddSingleton<INotification, Notification>();
    }
}
