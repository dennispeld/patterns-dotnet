using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Interpreter
{
    public class TerminalExpression : Expression
    {
        public string Book { get; }

        public TerminalExpression(string book)
        {
            Book = book;
        }

        public bool Interpreter(string text)
        {
            return text.Contains(Book);
        }
    }
}
