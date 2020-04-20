using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Flyweight
{
    public class EBook : OrderItem
    {
        public EBook()
        {
            Type = Type.eBook;
        }

        public override void Display()
        {
            Console.WriteLine($"{Type} is in the order.");
        }
    }
}
