using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Interpreter
{
    public static class Starter
    {
        public static void Run()
        {
            Expression book1 = new TerminalExpression("The beach");
            Expression book2 = new TerminalExpression("Alchemist");
            Expression available = new OrExpression(book1, book2);

            // We want to check if either Alchemist or 100 years of solitude is available in the library
            Console.WriteLine($"At least one of the books (\"Alchemist\" or \"100 years of solitude\") is available in the library: {available.Interpreter("100 years of solitude, Alchemist")}");

            Expression bothAvailable = new AndExpression(book1, book2);
            Console.WriteLine($"Both books (\"Alchemist\" and \"The beach\") are available in the library: {bothAvailable.Interpreter("The beach, Alchemist")}");
        }
    }
}
