using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Bridge
{
    public interface IOrderingSystem
    {
        void Place(string order);
    }
}
