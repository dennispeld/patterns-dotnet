using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Adapter
{
    class BookAdapter : Quote
    {
        private Book _book;

        public BookAdapter(Book book)
        {
            _book = book;
        }

        public void AddQuoteFromBook(int page, int offset, int count)
        {
            string text = _book.Read(page);

            FindAndSaveQuote(text, offset, count);
        }
    }
}
