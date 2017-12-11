//using System;
//using System.Threading.Tasks;
//using DevCon.Query.Services.RemovedProducts;
//using Mapster;
//using Microsoft.AspNetCore.Mvc;
//
//namespace DevCon.Api.Query.Controllers
//{
//    [Route("query/products/removed")]
//    public class RemovedProductsQueryController : Controller
//    {
//        private readonly IRemovedProductsRepository _removedProductsRepository;
//
//        public RemovedProductsQueryController(IRemovedProductsRepository removedProductsRepository)
//        {
//            _removedProductsRepository = removedProductsRepository;
//        }
//
//        [HttpGet]
//        public async Task<IActionResult> GetRemovedProductsAsync([FromRoute]Guid cartId)
//        {
//            var projection = await _removedProductsRepository.GetProjectionAsync();
//            return Ok(projection.Adapt<Models.RemovedProductsProjection>());
//        }
//
//    }
//}
