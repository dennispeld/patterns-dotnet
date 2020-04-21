using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PATTERNS.NET.Behavioral.Mediator
{
    public class Book
    {
        private readonly string title;
        private readonly OnlineBookstore store;
        private int amountInStock;

        public Book(string title, int amountInStock, OnlineBookstore store)
        {
            this.title = title;
            this.store = store;
            this.amountInStock = amountInStock;
        }

        public void Purchase(int amount)
        {
            this.amountInStock -= amount;

            if (amountInStock >= 0) {
                var args = new BookPurchasedEventArgs(this.title, amount);
                store.Purchase(args);
            }
            else {
                Console.WriteLine($"The book \"{this.title}\" is out of stock.");
            }
        }
    }
}
