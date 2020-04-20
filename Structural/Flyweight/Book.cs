using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Flyweight
{
    public class Book : OrderItem
    {
        public Book()
        {
            Type = Type.Book;
        }

        public override void Display()
        {
            Console.WriteLine($"{Type} is in the order.");
        }
    }
}
