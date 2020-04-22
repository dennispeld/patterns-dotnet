using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.TemplateMethod
{
    public static class Starter
    {
        public static void Run()
        {
            FirstEdition firstEdition = new FirstEdition();
            firstEdition.Publish();

            SecondEdition secondEdition = new SecondEdition();
            secondEdition.Publish();

            ThirdEdition thirdEdition = new ThirdEdition();
            thirdEdition.Publish();
        }
    }
}
