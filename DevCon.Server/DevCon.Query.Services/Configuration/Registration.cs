using Cars.Configuration;
using DevCon.Query.Services.Carts;
using DevCon.Query.Services.Products;
using DevCon.Query.Services.RemovedProducts;
using Microsoft.Extensions.DependencyInjection;

namespace DevCon.Query.Services.Configuration
{
    public static class Registration
    {
        public static IServiceCollection RegisterQueryServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<ICartRepository, CartRepository>();
            services.AddSingleton<IRemovedProductsRepository, RemovedProductsRepository>();
            services.RegisterEventHandlersInAssemblyOf<ProductCatalogSettings>();

            return services;
        }

    }


}
