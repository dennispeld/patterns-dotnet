using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Facade
{
    public enum ItemType
    {
        Book,
        eBook
    }

    public class OrderItem
    {
        public string Id { get; }
        public string Name { get; }
        public int Amount { get; }
        public ItemType Type { get; }

        public OrderItem(string name, int amount, ItemType type)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Amount = amount;
            Type = type;
        }
    }
}
