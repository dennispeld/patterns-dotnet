using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Creational.Factory
{
    public static class Starter
    {
        public static void Run()
        {
            ReadableFactory readableFactory = new ReadableFactory();

            // Book
            IReadable book = readableFactory.GetReadable(ReadableType.Book);
            book.Read("The beach", "Alex Garland", 124);

            // Magazine
            IReadable magazine = readableFactory.GetReadable(ReadableType.Magazine);
            magazine.Read("Men's Health", null, 48);

        }
    }
}
