using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.Mediator
{
    public enum WarehouseAction
    {
        Purchased,
        CheckedAvailability,
        FilledStock
    }
    public class BookPurchasedEventArgs : WarehouseEventArgs
    {
        public string Title;
        public int Amount;

        public BookPurchasedEventArgs() : base() { }

        public BookPurchasedEventArgs(string title, int amount)
        {
            Title = title;
            Amount = amount;
        }

        public override void PrintEvent(WarehouseAction action)
        {
            if (action == WarehouseAction.Purchased)
                Console.WriteLine($"{Amount} x \"{Title}\" was purchased.");
            else
                Console.WriteLine($"Unknown action.");
        }
    }
}
