using System.Collections.Generic;

namespace DevCon.Api.Query.Models
{
    public class RemovedProductsProjection
    {
        public IList<RemovedProductTotal> Products = new List<RemovedProductTotal>();

        public class RemovedProductTotal
        {
            public string Sku { get; set; }

            public int Count { get; set; }
        }
    }

}
