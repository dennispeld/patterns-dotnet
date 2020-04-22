using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.State
{
    internal class Finished : ReadingProgress
    {
        public Finished(ReadingProgress progress): this(progress.Book, progress.CurrentPage) { }

        public Finished(Book book, int currentPage)
        {
            this.book = book;
            this.currentPage = currentPage;

            Init();
        }

        private void Init()
        {
            addedPages = this.book.Pages - this.currentPage;
            finished = true;
        }

        public override void AddReadPages(int pages) { }

        public override void CheckReadingProgress() { }
    }
}
