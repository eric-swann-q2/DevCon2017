using System.Threading.Tasks;

namespace DevCon.Query.Services.RemovedProducts
{
    public interface IRemovedProductsDenormalizer
    {
        Task RebuildAsync();
    }
}