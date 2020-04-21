using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.ChainOfResponsibility
{
    public abstract class Packer
    {
        public Packer Supervisor;

        public void SetSupervisor(Packer supervisor)
        {
            Supervisor = supervisor;
        }

        public abstract void Handle(Order order);
    }
}
