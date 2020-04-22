using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Observer
{
    public class AvailabilityChangedEventArgs: EventArgs
    {
        public Book Book;
        public bool IsAvailable;
    }
}
