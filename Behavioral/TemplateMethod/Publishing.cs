using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.TemplateMethod
{
    public abstract class Publishing
    {
        public abstract void EditScript();
        public abstract void Print();

        public virtual void Distribute()
        {
            Console.WriteLine("Distribution completed.");
        }

        public void Publish()
        {
            EditScript();
            Print();
            Distribute();
        }
    }
}
