using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Memento
{
    class PublisherMemento
    {
        public string Name { get; }
        public string Phone { get; }
        public string Address { get; }

        public PublisherMemento(string name, string phone, string address)
        {
            Name = name;
            Phone = phone;
            Address = address;
        }
    }
}
