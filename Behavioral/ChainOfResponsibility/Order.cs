using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.ChainOfResponsibility
{
    public class Order
    {
        public string Id { get; }
        public double Price { get; }
        public string Customer { get; }

        public Order(double price, string customer)
        {
            Id = Guid.NewGuid().ToString();
            Price = price;
            Customer = customer;
        }
    }
}
