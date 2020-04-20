using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Proxy
{
    public class EBook
    {
        public string Title { get; }
        public string Author { get; }
        public string File { get; set; }

        public EBook(string title, string author, string file)
        {
            Title = title;
            Author = author;
            File = file;
        }
    }
}
