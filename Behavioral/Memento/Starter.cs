using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Memento
{
    public static class Starter
    {
        public static void Run()
        {
            Publisher publisher = new Publisher();
            publisher.Name = "Penguin Books";
            publisher.Address = "80 Strand, London WC2R 0RL, England";
            publisher.Phone = "+44 1234 5678 29";

            ContactBook contactBook = new ContactBook();
            contactBook.Memento = publisher.Save();
            Console.WriteLine(publisher.ToString());

            // oops
            publisher.Name = "_ deleted by accident _";
            Console.WriteLine(publisher.ToString());

            // restore
            publisher.Restore(contactBook.Memento);
            Console.WriteLine(publisher.ToString());
        }
    }
}
