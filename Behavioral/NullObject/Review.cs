using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PATTERNS.NET.Behavioral.NullObject
{
    public class Review : IReview
    {
        private readonly List<string> reviews;

        public Review()
        {
            this.reviews = new List<string>();
        }

        public int DisplayAllReviews()
        {
            foreach (var review in reviews) {
                Console.WriteLine(review);
            }

            return reviews.Count;
        }

        public void Save(string review)
        {
            reviews.Add(review);
        }
    }
}
