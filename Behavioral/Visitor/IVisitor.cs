using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Visitor
{
    public interface IVisitor
    {
        void Visit(BookElement element);
    }
}
