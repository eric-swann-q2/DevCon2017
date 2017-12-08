using Cars.Configuration;
using DevCon.Command.Services.Commands.CreateCart;
using Microsoft.Extensions.DependencyInjection;

namespace DevCon.Command.Services.Configuration
{
    public static class Registration
    {
        public static IServiceCollection RegisterCommandServices(this IServiceCollection services)
        {
            services.RegisterCommandHandlersInAssemblyOf<CreateCartCommand>();

            return services;
        }
    }
}
