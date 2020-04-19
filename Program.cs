using System;

namespace PATTERNS.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BUILDER");
            Creational.Builder.Starter.Run();

            Console.WriteLine();
            Console.WriteLine("FACTORY");
            Creational.Factory.Starter.Run();

            Console.WriteLine();
            Console.WriteLine("PROTOTYPE");
            Creational.Prototype.Starter.Run();

            Console.WriteLine();
            Console.WriteLine("SINGLETON");
            Creational.Singleton.Starter.Run();
        }
    }
}
