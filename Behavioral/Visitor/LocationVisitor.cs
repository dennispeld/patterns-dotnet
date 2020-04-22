using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Visitor
{
    public class LocationVisitor : IVisitor
    {
        public string Location { get; }

        public LocationVisitor(string location)
        {
            Location = location;
        }

        public void Visit(BookElement element)
        {
            Book book = element as Book;
            book.Location = $"{Location} / {book.Author}";
        }
    }
}
