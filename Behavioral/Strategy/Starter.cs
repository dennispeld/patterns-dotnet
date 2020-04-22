using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Strategy
{
    public static class Starter
    {
        public static void Run()
        {
            SortingMethod sortingMethod = new SortingMethod();

            // Let's build a small book collection
            List<Book> books = new List<Book>() {
                new Book("The beach", "Alex Garland", Genre.NonFiction, CoverColor.Blue),
                new Book("Alchemist", "Paulo Coelho", Genre.Fiction, CoverColor.Yellow),
                new Book("100 years of solitude", "Gabriel Garcia Marquez", Genre.Fiction, CoverColor.Red),
                new Book("Red har", "unknown author", Genre.Fairytale, CoverColor.Red),
                new Book("Snowman", "Jo Nesbö", Genre.Crime, CoverColor.Green)
            };
            sortingMethod.SetBookCollection(books);

            // Now, lets send this collection to different libraries and let them sort it
            sortingMethod.SetSortStrategy(new Library());
            sortingMethod.Sort();

            sortingMethod.SetSortStrategy(new Bookstore());
            sortingMethod.Sort();

            sortingMethod.SetSortStrategy(new DecorLibrary());
            sortingMethod.Sort();
        }
    }
}
