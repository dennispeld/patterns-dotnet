using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Strategy
{
    public enum Genre
    {
        Crime = 1,
        NonFiction = 2,
        Fairytale = 3,
        Fiction = 4
    }

    public enum CoverColor
    {
        Blue = 1,
        Green = 2,
        Red = 3,
        Yellow = 4
    }

    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public Genre Genre { get; }
        public CoverColor Color { get; }

        public Book(string title, string author, Genre genre, CoverColor color)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Color = color;
        }

        public override string ToString() => $"{Color} {Genre} \"{Title}\" by {Author}.";
    }
}
