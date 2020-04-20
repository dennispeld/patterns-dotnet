﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Decorator
{
    public class Book: PaperBook
    {
        public string Title { get; }
        public string Author { get; }
        public int Pages { get; }

        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        public override void Display()
        {
            Console.WriteLine($"\"{Title}\" by {Author} ({Pages} pages).");
        }
    }
}
