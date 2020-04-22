using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Strategy
{
    public class SortingMethod
    {
        private List<Book> books;
        private SortStrategy sortStrategy;

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }

        public void SetBookCollection(List<Book> books)
        {
            this.books = books;
        }

        public void Sort()
        {
            this.sortStrategy.Sort(this.books);
        }
    }
}
