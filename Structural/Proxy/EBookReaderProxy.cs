using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Proxy
{
    public class EBookReaderProxy : IBookReader
    {
        private EBook EBook;
        private readonly EBookReader _eBookReader = new EBookReader();

        public void ConvertAndLoad(EBook book)
        {
            Console.WriteLine($"The book \"{book.Title}\" was converted to AZW format successfully.");

            EBook = book;
            EBook.File = book.File + "_converted.azw";

            _eBookReader.Load(EBook);
        }

        public void Load(EBook book)
        {
            EBook = book;

            _eBookReader.Load(EBook);
        }

        public EBook Read()
        {
            if (EBook.File.Contains("_converted"))
                Console.WriteLine($"You are reading the book \"{EBook.Title}\" by {EBook.Author}.");
            else
                Console.WriteLine($"You are reading the book \"{EBook.Title}\" by {EBook.Author} in the old format. Consider converting to AZW.");

            return EBook;
        }
    }
}
