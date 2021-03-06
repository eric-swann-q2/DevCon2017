﻿using System;
using System.Collections.Generic;

namespace DevCon.Api.Query.Models
{
    public class CartProjection
    {
        public Guid CartId { get; set; }

        public string UserId { get; set; }

        public Decimal CartTotal { get; set; }

        public IList<CartProduct> Products = new List<CartProduct>();

        public class CartProduct
        {
            public string Sku { get; set; }

            public string Name { get; set; }

            public string Image { get; set; }

            public int Quantity { get; set; }

            public decimal SalePrice { get; set; }

            public bool CustomerTopRated { get; set; }
        }
    }

}
