using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Command
{
    public class BooksReceiver
    {
        public List<Book> Books { get; set; }

        public BooksReceiver()
        {
            Books = new List<Book>();
        }

        public void ExecuteCommand(LibraryCommand command, Book book)
        {
            command.Execute(Books, book);
        }

        public void ShowBooks()
        {
            foreach(var book in Books) {
                Console.WriteLine(book.ToString());
            }
        }
    }
}
