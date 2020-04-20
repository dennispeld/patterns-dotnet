using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Bridge
{
    public class NextDayDeliveryOrder : DeliverOrder
    {
        public override void Deliver()
        {
            Store.Place("Next day delivery order");
        }
    }
}
