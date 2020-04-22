using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.State
{
    public abstract class ReadingProgress
    {
        protected Book book;
        protected int currentPage;
        protected int addedPages;
        protected bool finished;

        public Book Book
        {
            get { return book; }
            set { book = value; }
        }

        public int CurrentPage
        {
            get { return currentPage; }
            set { currentPage = value; }
        }

        public abstract void AddReadPages(int pages);
        public abstract void CheckReadingProgress();
    }
}
