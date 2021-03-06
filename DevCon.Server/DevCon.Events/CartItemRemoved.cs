﻿using System;
using Cars.Events;

namespace DevCon.Events
{
    public class CartItemRemoved : DomainEvent
    {
        public CartItemRemoved() { }

        public CartItemRemoved(Guid aggregateId, string sku) : base(aggregateId)
        {
            Sku = sku;
        }

        public string Sku { get; protected set; }

    }
}