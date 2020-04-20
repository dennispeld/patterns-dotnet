using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Decorator
{
    public class EBook: Decorator
    {
        public bool Available { get; set; }

        protected int _downloads = 0;

        public EBook(PaperBook book, bool available) : base(book)
        {
            Available = available;
        }

        public void Download()
        {
            if (Available) {
                _downloads++;

                Console.WriteLine($"You have successfully downloaded the book for the {_downloads} time.");
            } else {
                Console.WriteLine($"The book is not available for downloads.");
            }
        }

        public void DisplayStatistics()
        {
            Console.WriteLine($"In total, eBooks were downloaded {_downloads} times.");
        }
    }
}
