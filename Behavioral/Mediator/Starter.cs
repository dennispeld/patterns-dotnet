using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Mediator
{
    public static class Starter
    {
        public static void Run()
        {
            var store = new OnlineBookstore();

            // setting only a stock of 5 books to the store
            var book = new Book("The beach", 5, store);

            _ = new Warehouse(store);

            book.Purchase(1);
            book.Purchase(1);
            book.Purchase(3);
            book.Purchase(1); // out of stock
            book.Purchase(2); // out of stock
        }
    }
}
