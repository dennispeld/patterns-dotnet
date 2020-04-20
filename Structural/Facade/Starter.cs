using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Facade
{
    public static class Starter
    {
        public static void Run()
        {
            OnlineStore store = new OnlineStore();
            List<OrderItem> order = new List<OrderItem>() {
                new OrderItem("The beach", 2, ItemType.Book),
                new OrderItem("Red Hat", 5, ItemType.Book),
                new OrderItem("Alchemist", 1, ItemType.eBook)
            };

            store.SummerizeOrder(order);
        }
    }
}
