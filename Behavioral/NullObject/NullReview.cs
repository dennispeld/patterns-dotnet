using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.NullObject
{
    public sealed class NullReview : IReview
    {
        public int DisplayAllReviews() { return 0; }

        public void Save(string review) { }
    }
}
