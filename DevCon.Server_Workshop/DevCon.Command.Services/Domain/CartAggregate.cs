using System;
using System.Collections.Generic;
using Cars.EventSource;
using DevCon.Events;

namespace DevCon.Command.Services.Domain
{
    public class CartAggregate : Aggregate
    {
        private readonly List<CartItem> _cartItems = new List<CartItem>();

        public CartAggregate() { }

        public CartAggregate(string userId)
        {
            Emit(new CartCreated(Guid.NewGuid(), userId));
        }

        /// <summary>
        /// Here's where we register event handlers
        /// </summary>
        protected override void RegisterEvents()
        {
            SubscribeTo<CartCreated>(OnCartCreated);
        }

        // We take actions internally on an event here

        private void OnCartCreated(CartCreated evt)
        {
            AggregateId = evt.AggregateId;
        }

    }
}