using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Creational.Prototype
{
    public static class Starter
    {
        public static void Run()
        {
            Book book = new Book(
                new Information("The beach", "Alex Garland"),
                new Location("National Library", "Test Str. 1"));

            Book copy = book.DeepCopy();
            copy.Location = new Location("City library", "Other Str. 2");

            Console.WriteLine("The book " + book.ToString());
            Console.WriteLine("The copy of a book " + copy.ToString());
        }
    }
}
