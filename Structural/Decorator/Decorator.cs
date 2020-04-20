using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Decorator
{
    public abstract class Decorator: PaperBook
    {
        protected PaperBook _paperBook;

        public Decorator(PaperBook paperBook)
        {
            _paperBook = paperBook;
        }

        public override void Display()
        {
            _paperBook.Display();
        }
    }
}
