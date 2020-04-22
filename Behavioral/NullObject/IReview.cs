using System;
using System.Collections.Generic;
using System.Text;

namespace PATTERNS.NET.Behavioral.NullObject
{
    public interface IReview
    {
        void Save(string review);
        int DisplayAllReviews();
    }
}
