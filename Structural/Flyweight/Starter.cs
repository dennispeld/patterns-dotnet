using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Flyweight
{
    public static class Starter
    {
        public static void Run()
        {
            OrderItemFactory factory = new OrderItemFactory();
            List<string> order = new List<string>() {
                "book", "book", "ebook", "book"
            };

            foreach (var item in order) {
                OrderItem orderItem = factory.GetOrderItem(item);
                orderItem.Display();
            }
        }
    }
}
