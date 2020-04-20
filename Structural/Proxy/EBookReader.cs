using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Proxy
{
    public class EBookReader : IBookReader
    {
        private EBook EBook;

        public void Load(EBook book)
        {
            Console.WriteLine($"The file \"{book.File}\" was loaded to the eBook reader.");

            EBook = book;
        }

        public EBook Read()
        {
            Console.WriteLine($"You are reading the book \"{EBook.Title}\" by {EBook.Author}.");

            return EBook;
        }

    }
}
