using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Decorator
{
    public static class Starter
    {
        public static void Run()
        {
            Book book = new Book("The beach", "Alex Garland", 356);
            book.Display();

            EBook eBook = new EBook(book, true);
            eBook.Download();
            eBook.Download();
            eBook.Download();
            eBook.Available = false;
            eBook.Download();

            eBook.DisplayStatistics();
        }
    }
}
