using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Iterator
{
    public interface IBookIterator
    {
        Book First();
        Book Next();
        Book CurrentBook { get; }
        bool NoMoreBooks { get; }
    }
}
