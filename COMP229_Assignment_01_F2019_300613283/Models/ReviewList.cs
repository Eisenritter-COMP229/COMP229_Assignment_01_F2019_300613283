using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP229_Assignment_01_F2019_300613283.Models
{
    public class ReviewList
    {
        private static List<Review> reviews = new List<Review>();
        public int ReviewID { get; set; }

        public static IEnumerable<Review> Reviews        {
            get
            {
                return reviews;
            }
        }

        public static void AddReview(Review review)
        {
            reviews.Add(review);
        }
    }
}
