using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Visitor
{
    public abstract class BookElement
    {
        public abstract void Accept(IVisitor visitor);
    }
}
