using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Creational.Singleton
{
    public sealed class Library
    {
        public string Name { get; }
        public string Address { get; }
        public static int Count { get; private set; }
        public static Library Instance => instance.Value;

        private static readonly Lazy<Library> instance = new Lazy<Library>(() =>
        {
            Count++;

            return new Library("National Library", "Test Str. 1");
        });

        private Library(string name, string address)
        {
            Name = name;
            Address = address;

            Console.WriteLine($"Created a new instanse of a Library ({Name} at {Address}).");
        }
    }
}
