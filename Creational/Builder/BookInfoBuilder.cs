using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Creational.Builder
{
    public class BookInfoBuilder: BookBuilder
    {
        public BookInfoBuilder(Book book): base(book)
        {
            this.book = book;
        }

        public BookInfoBuilder Title(string title)
        {
            book.Title = title;

            return this;
        }

        public BookInfoBuilder Author(string author)
        {
            book.Author = author;

            return this;
        }

        public BookInfoBuilder Genre(Genre genre)
        {
            book.Genre = genre;

            return this;
        }
    }
}
