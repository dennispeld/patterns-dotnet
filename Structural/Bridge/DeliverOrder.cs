using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Bridge
{
    public abstract class DeliverOrder
    {
        // a reference to the Implementator
        public IOrderingSystem Store;

        public abstract void Deliver();
    }
}
