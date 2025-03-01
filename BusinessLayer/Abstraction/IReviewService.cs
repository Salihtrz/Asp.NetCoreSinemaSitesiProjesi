﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Class;

namespace BusinessLayer.Abstraction
{
    public interface IReviewService<Review>
    {
        List<Review> GetAllReviews();
        Review GetReviewById(int id);
        void addReview(Review review);
        void removeReview(Review review);
        void updateReview(Review review);
        List<Review> GetAllReviewsWithUsers(int id);
    }
}
