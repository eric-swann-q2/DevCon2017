//using System.Threading.Tasks;
//using DevCon.Query.Services.Products;
//using Microsoft.AspNetCore.Mvc;
//
//namespace DevCon.Api.Query.Controllers
//{
//    [Route("query/products")]
//    public class ProductQueryController : Controller
//    {
//        private readonly IProductRepository _productRepository;
//
//        public ProductQueryController(IProductRepository productRepository)
//        {
//            _productRepository = productRepository;
//        }
//
//        [HttpGet]
//        public async Task<IActionResult> GetProductListAsync()
//        {
//            return Ok(await _productRepository.GetProductListAsync());
//        }
//        
//    }
//}
