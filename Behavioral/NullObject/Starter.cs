using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.NullObject
{
    public static class Starter
    {
        public static void Run()
        {
            Book book = new Book("The beach", "Alex Garland", new Review());
            book.AddReview("Fantastic!");
            book.AddReview("A truly masterpiece!");
            book.AddReview("Meh...");
            book.DisplayReviews();

            // Scrapbook doesnt have reviews, but we can try to add some
            Book scrapbook = new Book("Scrapbook", "No Author", new NullReview());
            scrapbook.AddReview("What. The. Hell.");
            scrapbook.AddReview("What. The. Hell. Again.");
            scrapbook.DisplayReviews();
        }
    }
}
