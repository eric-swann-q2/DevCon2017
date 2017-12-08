using System.Collections.Generic;
using Cars.Projections;
using MongoDB.Bson.Serialization.Attributes;

namespace DevCon.Query.Services.RemovedProducts
{
    public class RemovedProductsProjection : IProjection
    {
        [BsonId]
        public string ProjectionId => Constants.ProjectionId;

        public IList<RemovedProductTotal> Products = new List<RemovedProductTotal>();

        public class RemovedProductTotal
        {
            public string Sku { get; set; }

            public int Count { get; set; }
        }
    }

}
