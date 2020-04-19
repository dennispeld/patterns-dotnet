using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Creational.Factory
{
    #nullable enable
    public class Magazine: IReadable
    {
        public void Read(string title, string? author, int pages)
        {
            Console.WriteLine($"You have completed {pages} pages of the magazine \"{title}\".");
        }
    }
}
