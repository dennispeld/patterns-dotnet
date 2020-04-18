using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Creational.Builder
{
    public static class Starter
    {
        public static void Run()
        {
            var bookBuilder = new BookBuilder();
            Book book = bookBuilder
                .Info
                    .Title("The beach")
                    .Author("Alex Garland")
                    .Genre(Genre.Fiction)
                .Located
                    .At("Test Street 1")
                    .In("National Library")
                .Currently
                    .Is(Status.Available)
                    .Since(DateTime.Now.AddDays(-5));

            Console.WriteLine(book.ToString());
        }
    }
}
