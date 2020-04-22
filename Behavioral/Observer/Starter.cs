using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Observer
{
    public static class Starter
    {
        public static void Run()
        {
            // create books
            Book book1 = new Book("The beach", "Alex Garland");
            Book book2 = new Book("Alchemist", "Paulo Coelho");
            Book book3 = new Book("100 years of solitude", "Gabriel Garcia Marquez");

            // Create readers and add books to their watchlists
            Reader reader1 = new Reader("Dennis");
            reader1.AddBookToWatchList(book1);
            reader1.AddBookToWatchList(book2);

            Reader reader2 = new Reader("Luis");
            reader2.AddBookToWatchList(book2);
            reader2.AddBookToWatchList(book3);

            // Change the availability of books
            book2.SetAvailability(false);
            book3.SetAvailability(false);
            book3.SetAvailability(true);
            book1.SetAvailability(false);

            // Display the notifications for each reader
            reader1.DisplayNotifications();
            reader2.DisplayNotifications();
        }
    }
}
