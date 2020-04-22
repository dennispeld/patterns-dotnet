using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.TemplateMethod
{
    public class ThirdEdition : Publishing
    {
        public override void EditScript()
        {
            Console.WriteLine("Third edition of a book was edited.");
        }

        public override void Print()
        {
            Console.WriteLine("Third edition of a book was printed with the amount of 300000.");
        }
    }
}
