using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Structural.Facade
{
    public class OnlineStore
    {
        private Book _book = new Book();
        private EBook _ebook = new EBook();

        public void SummerizeOrder(List<OrderItem> order)
        {
            foreach (var item in order) {
                if (item.Type == ItemType.Book) {
                    _book.Order(item.Name, item.Amount);
                } else {
                    _ebook.Order(item.Name, item.Amount);
                }

                Console.WriteLine($"{item.Amount} x {item.Type} \"{item.Name}\" was added to the order.");
            }
        }
    }
}
