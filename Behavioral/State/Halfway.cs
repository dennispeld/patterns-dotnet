using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.State
{
    internal class Halfway : ReadingProgress
    {
        public Halfway(ReadingProgress progress): this(progress.Book, progress.CurrentPage) { }

        public Halfway(Book book, int currentPage)
        {
            this.book = book;
            this.currentPage = currentPage;

            Init();
        }

        private void Init()
        {
            addedPages = this.book.Pages / 2;
            finished = false;
        }

        public override void AddReadPages(int pages)
        {
            this.currentPage += pages;

            CheckReadingProgress();
        }

        public override void CheckReadingProgress()
        {
            if (this.currentPage >= book.Pages)
                book.Progress = new Finished(this);
        }
    }
}
