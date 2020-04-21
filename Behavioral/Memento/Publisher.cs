using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Memento
{
    class Publisher
    {
        public string Name;
        public string Phone;
        public string Address;

        public PublisherMemento Save()
        {
            Console.WriteLine($"Saved the publisher's current state.");
            
            return new PublisherMemento(Name, Phone, Address);
        }

        public void Restore(PublisherMemento memento)
        {
            Console.WriteLine($"Restoring the previous state of a publisher...");
            
            Name = memento.Name;
            Phone = memento.Phone;
            Address = memento.Address;
        }

        public override string ToString() => $"{Name} at {Address}, phone: {Phone}.";
    }
}
