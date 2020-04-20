using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Bridge
{
    public static class Starter
    {
        public static void Run()
        {
            DeliverOrder deliverOrder = new NextDayDeliveryOrder();
            deliverOrder.Store = new OnlineStore();
            deliverOrder.Deliver();

            deliverOrder.Store = new Bookstore();
            deliverOrder.Deliver();

            deliverOrder = new SelfPickupOrder();
            deliverOrder.Store = new Bookstore();
            deliverOrder.Deliver();

        }
    }
}
