using Cars.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DevCon.Query.Services.Products;
using DevCon.Query.Services.RemovedProducts;

//using DevCon.Query.Services.Carts;

namespace DevCon.Query.Services.Configuration
{
    public static class Registration
    {
        public static IServiceCollection RegisterQueryServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.RegisterEventHandlersInAssemblyOf<ProductCatalogSettings>();

//            services.AddSingleton<ICartRepository, CartRepository>();

//            services.AddSingleton<IRemovedProductsRepository, RemovedProductsRepository>();
//            services.AddScoped<IRemovedProductsDenormalizer, RemovedProductsDenormalizer>();

            return services;
        }

    }


}
