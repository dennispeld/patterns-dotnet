using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Interpreter
{
    public interface Expression
    {
        bool Interpreter(string text);
    }
}
