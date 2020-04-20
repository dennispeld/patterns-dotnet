using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Flyweight
{
    public enum Type
    {
        Book,
        eBook
    }

    public abstract class OrderItem
    {
        protected string Name;
        protected Type Type;
        protected decimal Price;

        public abstract void Display();
    }
}
