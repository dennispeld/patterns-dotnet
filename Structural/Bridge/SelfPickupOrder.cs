using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Bridge
{
    public class SelfPickupOrder : DeliverOrder
    {
        public override void Deliver()
        {
            Store.Place("Self pick-up order");
        }
    }
}
