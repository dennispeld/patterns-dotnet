using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Bridge
{
    public class Bookstore : IOrderingSystem
    {
        public void Place(string order)
        {
            Console.WriteLine($"{order} at the bookstore is placed.");
        }
    }
}
