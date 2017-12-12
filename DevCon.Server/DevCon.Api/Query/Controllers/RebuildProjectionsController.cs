using System.Threading.Tasks;
using DevCon.Query.Services.RemovedProducts;
using Microsoft.AspNetCore.Mvc;

namespace DevCon.Api.Query.Controllers
{
    [Route("query/projections/rebuild")]
    public class RebuildProjectionsController : Controller
    {
        private readonly IRemovedProductsDenormalizer _removedProductsDenormalizer;

        public RebuildProjectionsController(IRemovedProductsDenormalizer removedProductsDenormalizer)
        {
            _removedProductsDenormalizer = removedProductsDenormalizer;
        }

        [HttpPost]
        public async Task<IActionResult> RebuildProjectionsAsync()
        {
            await _removedProductsDenormalizer.RebuildAsync();
            return Ok();
        }

    }
}
