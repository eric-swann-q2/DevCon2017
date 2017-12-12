//using System.Linq;
//using System.Threading.Tasks;
//using Cars.EventSource.SerializedEvents;
//using Cars.EventSource.Storage;
//using Cars.EventStore.MongoDB.Projections;
//using Cars.Handlers;
//using Cars.Projections;
//using DevCon.Events;
//
//namespace DevCon.Query.Services.RemovedProducts
//{
//    public class RemovedProductsDenormalizer : MongoDenormalizer, IEventHandler<CartItemRemoved>, IRemovedProductsDenormalizer
//    {
//
//        public RemovedProductsDenormalizer(IProjectionRepository projectionRepository, IEventStore eventStore, IEventSerializer eventSerializer) 
//            : base(projectionRepository, eventStore, eventSerializer)
//        {
//        }
//
//        public async Task ExecuteAsync(CartItemRemoved evt)
//        {
//            var removedProductsProjection = await Repository.RetrieveAsync<RemovedProductsProjection>(Constants.ProjectionId) 
//                ?? new RemovedProductsProjection();
//            var product = removedProductsProjection.Products.FirstOrDefault(x => x.Sku == evt.Sku);
//            if (product == null)
//            {
//                product = new RemovedProductsProjection.RemovedProductTotal {Sku = evt.Sku, Count = 1};
//                removedProductsProjection.Products.Add(product);
//            }
//            else
//            {
//                product.Count++;
//            }
//            await Repository.UpsertAsync(removedProductsProjection, evt);
//        }
//
//        public async Task RebuildAsync()
//        {
//            await RebuildAsync<RemovedProductsProjection>();
//        }
//    }
//}
