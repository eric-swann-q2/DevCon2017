using System.Collections.Generic;
using System.Threading.Tasks;
using DevCon.Query.Services.Configuration;
using Fiver.Api.HttpClient;

namespace DevCon.Query.Services.Products
{
    public class ProductRepository : IProductRepository
    {
        private readonly IProductCatalogSettings _settings;

        public ProductRepository(IProductCatalogSettings settings)
        {
            _settings = settings;
        }

        public async Task<IList<Product>> GetProductListAsync()
        {
            var response = await HttpRequestFactory.Get(_settings.ProductListUri);

            var result = response.ContentAsType<ProductListResult>();
            return result.Products;
        }

        public class ProductListResult
        {
            public List<Product> Products { get; set; }
        }
    }
}
