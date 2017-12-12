using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevCon.Query.Services.Products
{
    public interface IProductRepository
    {
        Task<IList<Product>> GetProductListAsync();
    }
}