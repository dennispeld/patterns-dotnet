using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace PATTERNS.NET.Behavioral.Command
{
    public enum CommandOption
    {
        Add,
        Remove,
        Edit
    }

    public class Library
    {
        private LibraryCommand _command;
        private Book _book;
        private readonly BooksReceiver _booksReceiver; // receiver

        public Library()
        {
            _booksReceiver = new BooksReceiver();
        }

        public void SetCommand(CommandOption commandOption)
        {
            _command = (commandOption) switch
            {
                CommandOption.Add => new AddCommand(),
                CommandOption.Remove => new RemoveCommand(),
                CommandOption.Edit => new EditCommand(),
                _ => new AddCommand()
            };
        }

        public void SetBook(Book book)
        {
            _book = book;
        }

        public void ExecuteCommand()
        {
            _booksReceiver.ExecuteCommand(_command, _book);
        }

        public void DisplayLibrary()
        {
            _booksReceiver.ShowBooks();
        }
    }
}
