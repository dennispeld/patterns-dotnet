using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Mediator
{
    /// <summary>
    /// Warehouse is subscribed to events to know when a purchase was made.
    /// </summary>
    public class Warehouse
    {
        private readonly OnlineBookstore store;

        public Warehouse(OnlineBookstore store)
        {
            this.store = store;

            store.Events += Store_Events;
        }

        private void Store_Events(object sender, WarehouseEventArgs args)
        {
            if (args is BookPurchasedEventArgs purchased) {
                Console.WriteLine($"{purchased.Amount} x \"{purchased.Title}\" was purchased.");
            }
        }
    }
}
