using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.State
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public int Pages { get; }
        private ReadingProgress _progress;

        public ReadingProgress Progress
        {
            get { return _progress; }
            set { _progress = value; }
        }

        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;

            _progress = new Started(this, 0);
        }

        public void ReadPages(int pages)
        {
            _progress.AddReadPages(pages);

            var completePages = Progress.CurrentPage < Pages ? Progress.CurrentPage : Pages;

            Console.WriteLine($"{this} Complete pages: {completePages}. Current status: {Progress.GetType().Name}.");
        }

        public override string ToString() => $"\"{Title}\" by {Author}, {Pages} pages.";
    }
}
