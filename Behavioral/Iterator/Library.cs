using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Iterator
{
    public class Library : ILibrary
    {
        private readonly List<Book> _books = new List<Book>();
        public int Count => _books.Count;

        public Book this[int index]
        {
            get { return _books[index]; }
            set { _books.Add(value); }
        }

        public IBookIterator CreateIterator()
        {
            return new BookIterator(this);
        }
    }
}
