using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Flyweight
{
    public class OrderItemFactory
    {
        private readonly Dictionary<string, OrderItem> _order = new Dictionary<string, OrderItem>();

        public OrderItem GetOrderItem(string key)
        {
            OrderItem item;

            if (_order.ContainsKey(key)) {
                item = _order[key];
            } else {
                switch (key) {
                    case "book":
                        item = new Book();
                        break;
                    case "ebook":
                        item = new EBook();
                        break;
                    default:
                        throw new NotImplementedException();
                }

                _order.Add(key, item);
            }

            return item;
        }
    }
}
