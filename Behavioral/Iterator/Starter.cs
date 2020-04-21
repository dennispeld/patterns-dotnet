using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Iterator
{
    public static class Starter
    {
        public static void Run()
        {
            Library library = new Library();
            library[0] = new Book("The book 1", "The author 1");
            library[1] = new Book("The book 2", "The author 2");
            library[2] = new Book("The book 3", "The author 3");
            library[3] = new Book("The book 4", "The author 4");
            library[4] = new Book("The book 5", "The author 5");

            var iterator = library.CreateIterator();
            
            for (Book book = iterator.First(); !iterator.NoMoreBooks; book = iterator.Next()) {
                Console.WriteLine(book.ToString());
            }
        }
    }
}
