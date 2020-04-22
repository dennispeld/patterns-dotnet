using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.NullObject
{
    public class Book
    {
        private readonly IReview review;
        
        public string Title { get; }
        public string Author { get; }

        public Book(string title, string author, IReview review)
        {
            Title = title;
            Author = author;

            this.review = review;
        }

        public void AddReview(string review)
        {
            this.review.Save(review);
        }

        public void DisplayReviews()
        {
            Console.WriteLine($"Reviews of {this.ToString()}:");

            var count = this.review.DisplayAllReviews();

            if (count == 0)
                Console.WriteLine("No reviews.");
        }

        public override string ToString() => $"\"{Title}\" by {Author}";
    }
}
