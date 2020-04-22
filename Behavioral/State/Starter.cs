using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.State
{
    public static class Starter
    {
        public static void Run()
        {
            Book book = new Book("The beach", "Alex Garland", 356);
            book.ReadPages(25);
            book.ReadPages(50);
            book.ReadPages(25);
            book.ReadPages(100);
            book.ReadPages(50);
            book.ReadPages(140);
        }
    }
}
