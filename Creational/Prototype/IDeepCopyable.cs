using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Creational.Prototype
{
    public interface IDeepCopyable<T>
    {
        T DeepCopy();
    }
}
