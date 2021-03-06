﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PATTERNS.NET.Behavioral.Strategy
{
    public class DecorLibrary : SortStrategy
    {
        public override void Sort(List<Book> books)
        {
            Console.WriteLine($"{this.GetType().Name} sorts books by cover color:");

            foreach(var book in books.OrderBy(b => b.Color)) {
                Console.WriteLine(book.ToString());
            }
        }
    }
}
