using System.Threading.Tasks;

namespace DevCon.Query.Services.RemovedProducts
{
    public interface IRemovedProductsRepository
    {
        Task<RemovedProductsProjection> GetProjectionAsync();
    }
}