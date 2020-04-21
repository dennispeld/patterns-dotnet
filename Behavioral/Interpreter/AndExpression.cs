using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Interpreter
{
    public class AndExpression : Expression
    {
        public Expression First { get; set; }
        public Expression Second { get; set; }

        public AndExpression(Expression first, Expression second)
        {
            First = first;
            Second = second;
        }

        public bool Interpreter(string text)
        {
            return First.Interpreter(text) && Second.Interpreter(text);
        }
    }
}
