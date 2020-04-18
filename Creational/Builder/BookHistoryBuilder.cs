using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Creational.Builder
{
    public class BookHistoryBuilder: BookBuilder
    {
        public BookHistoryBuilder(Book book): base(book)
        {
            this.book = book;
        }

        public BookHistoryBuilder Is(Status status)
        {
            book.Status = status;

            return this;
        }

        public BookHistoryBuilder Since(DateTime updatedAt)
        {
            book.UpdatedAt = updatedAt;

            return this;
        }
    }
}
