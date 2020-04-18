using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Creational.Builder
{
    public enum Genre
    {
        Fiction,
        NonFiction,
        Classic,
        Crime,
        Novel,
        Fairytale,
        Other
    }

    public enum Status
    {
        Available,
        Taken
    }

    public class Book
    {
        // book info
        public string Title;
        public string Author;
        public Genre Genre;

        // book location
        public string Address;
        public string Library;

        // book history
        public Status Status;
        public DateTime UpdatedAt;

        public override string ToString()
        {
            return $"\"{Title}\" by {Author}, located in {Library} at {Address} is currently {Status} since {UpdatedAt}.";
        }
    }
}
