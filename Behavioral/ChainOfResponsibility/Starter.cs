using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.ChainOfResponsibility
{
    public static class Starter
    {
        public static void Run()
        {
            Packer junior = new JuniorPacker();
            Packer midlevel = new MidlevelPacker();
            Packer senior = new SeniorPacker();

            // creating a hierarchy
            junior.SetSupervisor(midlevel);
            midlevel.SetSupervisor(senior);

            // creating 20 orders to process
            for (int i = 0; i < 20; i++) {
                Order order = new Order(i*10, $"Customer {i}");
                junior.Handle(order);
            }
        }
    }
}
