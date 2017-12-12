using Cars.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DevCon.Query.Services.Products;
using DevCon.Query.Services.RemovedProducts;

////*** Uncomment this when running CART READ MODELS ***
//using DevCon.Query.Services.Carts;

namespace DevCon.Query.Services.Configuration
{
    public static class Registration
    {
        public static IServiceCollection RegisterQueryServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.RegisterEventHandlersInAssemblyOf<ProductCatalogSettings>();

//              //*** Uncomment this when running CART READ MODELS ***
//            services.AddSingleton<ICartRepository, CartRepository>();



//              //*** Uncomment this when running REMOVED PRODUCT READ MODELS ***
//            services.AddSingleton<IRemovedProductsRepository, RemovedProductsRepository>();
//            services.AddScoped<IRemovedProductsDenormalizer, RemovedProductsDenormalizer>();

            return services;
        }

    }


}
