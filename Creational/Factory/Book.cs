using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Creational.Factory
{
    public class Book : IReadable
    {
        public void Read(string title, string author, int pages)
        {
            Console.WriteLine($"You have completed {pages} pages of the book \"{title}\" by {author}.");
        }
    }
}
