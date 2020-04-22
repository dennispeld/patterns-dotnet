using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Observer
{
    public class Reader
    {
        public string Name { get; }
        private readonly List<Book> wantToRead;
        private readonly List<string> notifications;

        public Reader(string name)
        {
            Name = name;

            this.wantToRead = new List<Book>();
            this.notifications = new List<string>();
        }

        public void AddBookToWatchList(Book book)
        {
            this.wantToRead.Add(book);

            // subscribe to an event for a book's availability change
            book.AvailabilityChanged += Book_AvailabilityChanged;
        }

        private void Book_AvailabilityChanged(object sender, AvailabilityChangedEventArgs e)
        {
            var isAvailable = e.IsAvailable ? "available" : "not available";

            notifications.Add($"{e.Book} is {isAvailable}.");
        }

        public void DisplayNotifications()
        {
            Console.WriteLine($"Notifications for {Name}:");

            foreach (var notification in notifications) {
                Console.WriteLine(notification);
            }
        }

    }
}
