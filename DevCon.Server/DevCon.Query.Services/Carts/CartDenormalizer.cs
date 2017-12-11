//using System.Linq;
//using System.Threading.Tasks;
//using Cars.Events;
//using Cars.Projections;
//using DevCon.Events;
//using Mapster;
//
//namespace DevCon.Query.Services.Carts
//{
//    public class CartDenormalizer : 
//        IEventHandler<CartCreated>
//    {
//        private readonly IProjectionRepository _projectionRepository;
//
//        public CartDenormalizer(IProjectionRepository projectionRepository)
//        {
//            _projectionRepository = projectionRepository;
//        }
//
//        public async Task ExecuteAsync(CartCreated evt)
//        {
//            var cartProjection = new CartProjection
//            {
//                CartId = evt.AggregateId,
//                UserId = evt.UserId
//            };
//
//            await _projectionRepository.InsertAsync(cartProjection);
//        }
//
//    }
//}
