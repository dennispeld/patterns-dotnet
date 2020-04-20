using System;

namespace PATTERNS.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creational
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
            #endregion Creational

            #region Structural
            Console.WriteLine();
            Console.WriteLine("ADAPTER");
            Structural.Adapter.Starter.Run();

            Console.WriteLine();
            Console.WriteLine("BRIDGE");
            Structural.Bridge.Starter.Run();

            Console.WriteLine();
            Console.WriteLine("COMPOSITE");
            Structural.Composite.Starter.Run();

            Console.WriteLine();
            Console.WriteLine("DECORATOR");
            Structural.Decorator.Starter.Run();

            Console.WriteLine();
            Console.WriteLine("FACADE");
            Structural.Facade.Starter.Run();

            Console.WriteLine();
            Console.WriteLine("FLYWEIGHT");
            Structural.Flyweight.Starter.Run();

            Console.WriteLine();
            Console.WriteLine("PROXY");
            Structural.Proxy.Starter.Run();
            #endregion Structural
        }
    }
}
