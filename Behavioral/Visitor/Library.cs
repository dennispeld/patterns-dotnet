using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Visitor
{
    public class Library
    {
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var book in Books) {
                book.Accept(visitor);
            }
        }
    }
}
