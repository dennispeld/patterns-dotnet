using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PATTERNS.NET.Behavioral.Strategy
{
    public class Bookstore : SortStrategy
    {
        public override void Sort(List<Book> books)
        {
            Console.WriteLine($"{this.GetType().Name} sorts books by author:");

            foreach(var book in books.OrderBy(b => b.Author)) {
                Console.WriteLine(book.ToString());
            }
        }
    }
}
