using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Command
{
    public class Book
    {
        public string Id { get; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public Book(string title, string author, decimal price)
        {
            Id = Guid.NewGuid().ToString();
            Title = title;
            Author = author;
            Price = price;
        }

        public override string ToString() => $"\"{Title}\" by {Author} for {Price} EUR.";
    }
}
