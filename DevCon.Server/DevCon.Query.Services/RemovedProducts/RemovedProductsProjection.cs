using System.Collections.Generic;
using Cars.EventStore.MongoDB.Projections;

namespace DevCon.Query.Services.RemovedProducts
{
    public class RemovedProductsProjection : MongoProjectionBase
    {
        public override string ProjectionId => Constants.ProjectionId;

        public IList<RemovedProductTotal> Products = new List<RemovedProductTotal>();

        public class RemovedProductTotal
        {
            public string Sku { get; set; }

            public int Count { get; set; }
        }
    }

}
