using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.TemplateMethod
{
    public class FirstEdition : Publishing
    {
        public override void EditScript()
        {
            Console.WriteLine("First edition of a book was edited.");
        }

        public override void Print()
        {
            Console.WriteLine("First edition of a book was printed with the amount of 100000.");
        }
    }
}
