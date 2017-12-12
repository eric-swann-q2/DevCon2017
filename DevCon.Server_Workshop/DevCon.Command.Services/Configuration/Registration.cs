using Cars.Configuration;
using DevCon.Command.Services.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace DevCon.Command.Services.Configuration
{
    public static class Registration
    {
        public static IServiceCollection RegisterCommandServices(this IServiceCollection services)
        {
            services.RegisterCommandHandlersInAssemblyOf<CartItem>();

            return services;
        }
    }
}
