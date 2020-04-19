using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Creational.Prototype
{
    public class Book: IDeepCopyable<Book>
    {
        public Information Information { get; set; }
        public Location Location { get; set; }

        public Book(Information information, Location location)
        {
            Information = information;
            Location = location;
        }
        // Copy constructor
        public Book(Book other)
        {
            Information = new Information(other.Information);
            Location = new Location(other.Location);
        }

        public Book DeepCopy()
        {
            return new Book(this);
        }

        public override string ToString()
        {
            return $"\"{Information.Title}\" by {Information.Author} is now located in {Location.Library} at {Location.Address}.";
        }
    }

    public class Information
    {
        public string Title { get; }
        public string Author { get; }

        public Information(string title, string author)
        {
            Title = title;
            Author = author;
        }

        // Copy constructor
        public Information(Information other)
        {
            Title = other.Title;
            Author = other.Author;
        }
    }

    public class Location
    {
        public string Library { get; }
        public string Address { get; }

        public Location(string library, string address)
        {
            Library = library;
            Address = address;
        }

        // Copy constructor
        public Location(Location other)
        {
            Library = other.Library;
            Address = other.Address;
        }
    }
}
