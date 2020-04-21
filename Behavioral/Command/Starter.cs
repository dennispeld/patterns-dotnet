using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Command
{
    public static class Starter
    {
        public static void Run()
        {
            // Create books 
            Book book1 = new Book("The beach", "Alex Garland", 19);
            Book book2 = new Book("Red Hat", "unknown author", 24);
            Book book3 = new Book("Alchemist", "Paolo Coelho", 32);
            Book book4 = new Book("101 years of solitude", "Gabriel Garcia Marquez", 26);

            // Create a library and add books in it using ADD command
            Library library = new Library();
            library.SetCommand(CommandOption.Add);
            library.SetBook(book1);
            library.ExecuteCommand();

            library.SetBook(book2);
            library.ExecuteCommand();

            library.SetBook(book3);
            library.ExecuteCommand();

            library.SetBook(book4);
            library.ExecuteCommand();

            // Display the current state of the library
            library.DisplayLibrary();

            // Remove one book from the library using REMOVE command
            library.SetCommand(CommandOption.Remove);
            library.SetBook(book2);
            library.ExecuteCommand();

            // Edit a book title
            book4.Title = "Hundred Years of Solitude";

            // Edit the book using EDIT command
            library.SetCommand(CommandOption.Edit);
            library.SetBook(book4);
            library.ExecuteCommand();

            // Display the current state of the library
            Console.WriteLine("Updated library:");
            library.DisplayLibrary();
        }
    }
}
