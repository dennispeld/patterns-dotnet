using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.ChainOfResponsibility
{
    public class MidlevelPacker: Packer
    {
        protected readonly int _capability = 5;
        protected int _processed;

        public override void Handle(Order order)
        {
            if (_capability > _processed) {
                ++_processed;

                Console.WriteLine($"{this.GetType().Name} has prepared the order #{order.Id}.");
            } else if (Supervisor != null) {
                Supervisor.Handle(order);
            }
        }
    }
}
