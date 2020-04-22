using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PATTERNS.NET.Behavioral.Strategy
{
    public class Library : SortStrategy
    {
        public override void Sort(List<Book> books)
        {
            Console.WriteLine($"{this.GetType().Name} sorts books by genre:");

            foreach(var book in books.OrderBy(b => b.Genre)) {
                Console.WriteLine(book.ToString());
            }
        }
    }
}
