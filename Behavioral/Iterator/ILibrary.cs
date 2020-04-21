using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Iterator
{
    public interface ILibrary
    {
        IBookIterator CreateIterator();
    }
}
