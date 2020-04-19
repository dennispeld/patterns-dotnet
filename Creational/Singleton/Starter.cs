using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Creational.Singleton
{
    public static class Starter
    {
        public static void Run()
        {
            for (int i = 1; i < 6; i++) {

                if (Library.Count == 0)
                    Console.WriteLine($"Call #{i} of a Library class.");
                else
                    Console.WriteLine($"Call #{i} of a Library class. Instances count: {Library.Count}");

                _ = Library.Instance;
            }
        }
    }
}
