using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.State
{
    internal class Started : ReadingProgress
    {
        public Started(ReadingProgress progress): this(progress.Book, progress.CurrentPage) { }

        public Started(Book book, int currentPage)
        {
            this.book = book;
            this.currentPage = currentPage;

            Init();
        }

        private void Init()
        {
            addedPages = 0;
            finished = false;
        }

        public override void AddReadPages(int pages)
        {
            this.currentPage += pages;

            CheckReadingProgress();
        }

        public override void CheckReadingProgress()
        {
            if (this.currentPage > book.Pages / 2)
                book.Progress = new Halfway(this);
        }
    }
}
