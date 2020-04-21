using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Mediator
{
    public abstract class WarehouseEventArgs : EventArgs
    {
        public abstract void PrintEvent(WarehouseAction action);
    }
}
