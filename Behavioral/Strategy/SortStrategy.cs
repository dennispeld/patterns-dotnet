using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Strategy
{
    public abstract class SortStrategy
    {
        public abstract void Sort(List<Book> books);
    }
}
