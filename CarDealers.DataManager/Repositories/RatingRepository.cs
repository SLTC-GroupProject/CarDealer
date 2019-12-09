using CarDealers.DataManager.Context;
using CarDealers.DataManager.Interfaces;
using CarDealers.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealers.DataManager.Repositories
{
    public class RatingRepository : IRatingRepository
    {
        private CarDealersDbContext _DbContext;

        public RatingRepository(CarDealersDbContext DbContext)
        {
            this._DbContext = DbContext;
        }

        public bool CreateRating(Rating rating)
        {
            _DbContext.Add(rating);
            return Save();
        }

        public bool DeleteRating(Rating rating)
        {
            _DbContext.Remove(rating);
            return Save();
        }

        public ICollection<Rating> GetRating()
        {
            return _DbContext.Ratings.OrderBy(a => a.Id).ToList();
        }

        public Rating GetRating(int RatingId)
        {
            return _DbContext.Ratings.Where(a => a.Id == RatingId).FirstOrDefault();
        }

        public bool RatingExists(int RatingId)
        {
            return _DbContext.Ratings.Any(a => a.Id == RatingId);
        }

        public bool Save()
        {
            var saved = _DbContext.SaveChanges();
            return saved >= 0 ? true:false;
        }

        public bool UpdateRating(Rating rating)
        {
            _DbContext.Update(rating);
            return Save();
        }
    }
}
