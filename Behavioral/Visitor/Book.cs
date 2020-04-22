using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Visitor
{
    public enum Genre
    {
        Crime = 1,
        NonFiction = 2,
        Fairytale = 3,
        Fiction = 4
    }

    public class Book: BookElement
    {
        public string Title { get; }
        public string Author { get; }
        public Genre Genre { get; }
        public string Location { get; set; }

        public Book(string title, string author, Genre genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Location = $"{Genre} shelf / {Author}";
        }

        public override string ToString() => $"\"{Title}\" by {Author}. Location: {Location}.";

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
