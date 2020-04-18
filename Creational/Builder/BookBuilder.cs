using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Creational.Builder
{
    public class BookBuilder
    {
        protected Book book;

        // constructors
        public BookBuilder() => book = new Book();
        protected BookBuilder(Book book) => this.book = book;

        // other builders
        public BookInfoBuilder Info => new BookInfoBuilder(book);
        public BookLocatonBuilder Located => new BookLocatonBuilder(book);
        public BookHistoryBuilder Currently => new BookHistoryBuilder(book);

        // implement an implicit opertator to retrieve the final value
        public static implicit operator Book(BookBuilder bookBuilder) => bookBuilder.book;
    }
}
