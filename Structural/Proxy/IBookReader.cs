using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Proxy
{
    public interface IBookReader
    {
        void Load(EBook book);
        EBook Read();
    }
}
