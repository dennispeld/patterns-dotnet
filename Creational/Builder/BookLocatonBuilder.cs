using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Creational.Builder
{
    public class BookLocatonBuilder: BookBuilder
    {
        public BookLocatonBuilder(Book book): base(book)
        {
            this.book = book;
        }

        public BookLocatonBuilder At(string address)
        {
            book.Address = address;

            return this;
        }

        public BookLocatonBuilder In(string library)
        {
            book.Library = library;

            return this;
        }
    }
}
