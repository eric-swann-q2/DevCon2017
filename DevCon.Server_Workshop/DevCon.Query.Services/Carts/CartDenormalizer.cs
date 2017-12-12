//using System.Linq;
//using System.Threading.Tasks;
//using Cars.EventSource.SerializedEvents;
//using Cars.EventSource.Storage;
//using Cars.EventStore.MongoDB.Projections;
//using Cars.Handlers;
//using Cars.Projections;
//using DevCon.Events;
//using Mapster;
//
//namespace DevCon.Query.Services.Carts
//{
//    public class CartDenormalizer : MongoDenormalizer
//        ,IEventHandler<CartCreated>
//        ,IEventHandler<CartItemAdded>
//        ,IEventHandler<CartItemQuantityUpdated>
//        ,IEventHandler<CartItemRemoved>
//    {
//
//        public CartDenormalizer(IProjectionRepository projectionRepository, IEventStore eventStore, IEventSerializer eventSerializer) 
//            : base(projectionRepository, eventStore, eventSerializer)
//        {
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
//            await Repository.UpsertAsync(cartProjection, evt);
//        }
//
//        public async Task ExecuteAsync(CartItemAdded evt)
//        {
//            var cartProjection = await Repository.RetrieveAsync<CartProjection>(evt.AggregateId.ToString());
//            cartProjection.Products.Add(evt.Adapt<CartProjection.CartProduct>());
//            cartProjection.CartTotal = CalculateCartTotal(cartProjection);
//            await Repository.UpsertAsync(cartProjection, evt);
//        }
//
//        public async Task ExecuteAsync(CartItemQuantityUpdated evt)
//        {
//            var cartProjection = await Repository.RetrieveAsync<CartProjection>(evt.AggregateId.ToString());
//            var cartItem = cartProjection.Products.First(x => x.Sku == evt.Sku);
//            cartItem.Quantity = evt.Quantity;
//            cartProjection.CartTotal = CalculateCartTotal(cartProjection);
//            await Repository.UpsertAsync(cartProjection, evt);
//        }
//
//        public async Task ExecuteAsync(CartItemRemoved evt)
//        {
//            var cartProjection = await Repository.RetrieveAsync<CartProjection>(evt.AggregateId.ToString());
//            var cartItem = cartProjection.Products.First(x => x.Sku == evt.Sku);
//            cartProjection.Products.Remove(cartItem);
//            cartProjection.CartTotal = CalculateCartTotal(cartProjection);
//            await Repository.UpsertAsync(cartProjection, evt);
//        }
//
//        private decimal CalculateCartTotal(CartProjection projection)
//        {
//            decimal total = 0;
//            foreach (var product in projection.Products)
//            {
//                total += product.Quantity * product.SalePrice;
//            }
//            return total;
//        }
//    }
//}
