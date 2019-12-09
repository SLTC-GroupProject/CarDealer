using CarDealers.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealers.DataManager.Interfaces
{
    public interface IRatingRepository
    {
        ICollection<Rating> GetRating();
        Rating GetRating(int RatingId);
        bool RatingExists(int RatingId);
        bool CreateRating(Rating rating);
        bool UpdateRating(Rating rating);
        bool DeleteRating(Rating rating);
        bool Save();
    }
}
