using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PATTERNS.NET.Behavioral.Command
{
    public abstract class LibraryCommand
    {
        public abstract void Execute(List<Book> books, Book book);
    }

    public class AddCommand : LibraryCommand
    {
        public override void Execute(List<Book> books, Book book)
        {
            books.Add(book);
        }
    }

    public class RemoveCommand : LibraryCommand
    {
        public override void Execute(List<Book> books, Book book)
        {
            books.Remove(books.First(b => b.Id == book.Id));
        }
    }

    public class EditCommand : LibraryCommand
    {
        public override void Execute(List<Book> books, Book book)
        {
            var changedBook = books.First(b => b.Id == book.Id);
            changedBook.Title = book.Title;
            changedBook.Author = book.Author;
            changedBook.Price = book.Price;
        }
    }
}
