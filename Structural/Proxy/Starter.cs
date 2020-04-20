using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Proxy
{
    public static class Starter
    {
        public static void Run()
        {
            EBook book = new EBook("The beach", "Alex Garland", "thebeach4541166.mobi");

            EBookReader bookReader = new EBookReader();
            bookReader.Load(book);
            bookReader.Read();

            EBookReaderProxy proxy = new EBookReaderProxy();
            proxy.Load(book);
            proxy.Read();
            proxy.ConvertAndLoad(book);
            proxy.Read();
        }
    }
}
