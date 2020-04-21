using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Mediator
{
    public class OnlineBookstore
    {
        public event EventHandler<WarehouseEventArgs> Events;

        public void Purchase(WarehouseEventArgs args)
        {
            Events?.Invoke(this, args);
        }
    }
}
