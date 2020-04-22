using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Visitor
{
    public static class Starter
    {
        public static void Run()
        {
            Library library = new Library();
            library.AddBook(new Book("The beach", "Alex Garland", Genre.Fiction));
            library.AddBook(new Book("Alchemist", "Paulo Coelho", Genre.Fiction));

            // see the books catalog before the location change
            foreach (var book in library.Books) {
                Console.WriteLine(book.ToString());
            }

            library.Accept(new LocationVisitor("Fiction shelf / \"International authors\""));

            // see the books catalog with new locations
            foreach (var book in library.Books) {
                Console.WriteLine(book.ToString());
            }
        }
    }
}
