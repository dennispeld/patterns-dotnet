using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Adapter
{
    public static class Starter
    {
        public static void Run()
        {
            Book book = new Book("The beach", "Alex Garland");
            
            BookAdapter bookAdapter = new BookAdapter(book);

            bookAdapter.AddQuoteFromBook(136, 16, 10);
            bookAdapter.AddQuoteFromBook(298, 51, 10);
            bookAdapter.AddQuoteFromBook(342, 93, 10);

            bookAdapter.PrintAllQuotes();
        }
    }
}
