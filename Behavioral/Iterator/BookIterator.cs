using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Iterator
{
    public class BookIterator : IBookIterator
    {
        private Library _library;
        private int _current = 0;
        private int _step = 1;

        public BookIterator(Library library)
        {
            _library = library;
        }

        public Book First()
        {
            _current = 0;

            return _library[_current];
        }

        public Book Next()
        {
            _current += _step;

            if (!NoMoreBooks)
                return _library[_current];
            else
                return null;
        }

        public Book CurrentBook => _library[_current];

        public bool NoMoreBooks => _current >= _library.Count;
    }
}
