using System;
using System.Threading.Tasks;
using DevCon.Api.Command.Models;
using Microsoft.AspNetCore.Mvc;
// using DevCon.Command.Services.Commands.CreateCart;

namespace DevCon.Api.Command.Controllers
{
   [Route("command/carts")]
   public class CartController : Controller
   {
    //    private readonly ICreateCartHandler _createCartHandler;

    //    public CartController(ICreateCartHandler createCartHandler)
    //    {
    //        _createCartHandler = createCartHandler;
    //    }

    //    [HttpPost]
    //    public async Task<IActionResult> CreateCartAsync([FromBody]CreateCartRequest request)
    //    {
    //        var response = await _createCartHandler.ExecuteAsync(new CreateCartCommand(request.UserId));
    //        return Ok(new CreateCartResponse { CartId = response.AggregateId });
    //    }

        [HttpPost]
       public IActionResult CreateCartAsync([FromBody]CreateCartRequest request)
       {
           return Ok(new CreateCartResponse { CartId = Guid.Empty });
       }

   }
}
