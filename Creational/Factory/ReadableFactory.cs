using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Creational.Factory
{
    public enum ReadableType
    {
        Book,
        Magazine
    }

    public class ReadableFactory
    {
        public IReadable GetReadable(ReadableType type)
        {
            return (type) switch
            {
                ReadableType.Book => new Book(),
                ReadableType.Magazine => new Magazine(),
                _ => throw new NotImplementedException($"The type {nameof(type)} is not implemented.")
            };
        }
    }
}
