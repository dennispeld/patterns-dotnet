using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Observer
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }

        public event EventHandler<AvailabilityChangedEventArgs> AvailabilityChanged;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void SetAvailability(bool isAvailable)
        {
            AvailabilityChanged?.Invoke(this, new AvailabilityChangedEventArgs { Book = this, IsAvailable = isAvailable });
        }

        public override string ToString() => $"\"{Title}\" by {Author}";
    }
}
