using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Facade
{
    public interface IOrderable
    {
        OrderItem Order(string name, int amount);
    }
}
