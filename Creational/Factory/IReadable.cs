using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Creational.Factory
{
    #nullable enable
    public interface IReadable
    {
        public void Read(string title, string? author, int pages);
    }
}
