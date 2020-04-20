using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Facade
{
    public class EBook: IOrderable
    {
        public OrderItem Order(string name, int amount)
        {
            return new OrderItem(name, amount, ItemType.eBook);
        }
    }
}
