using CarDealers.DataManager.Context;
using CarDealers.DataManager.Interfaces;
using CarDealers.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealers.DataManager.Repositories
{
    public class AdvertistmentRepository : IAdvertistmentRepository
    {
        private CarDealersDbContext _DbContext;

        public AdvertistmentRepository(CarDealersDbContext DbContext)
        {
            this._DbContext = DbContext;
        }

        public bool AdvertistmentExists(int AdvertistmentId)
        {
            return _DbContext.Advertistments.Any(a => a.ID == AdvertistmentId);
            
        }

        public bool CreateAdvertistment(Advertistment advertistment)
        {
            _DbContext.Add(advertistment);
            return Save();
        }

        public bool DeleteAdvertistment(Advertistment advertistment)
        {
            _DbContext.Remove(advertistment);
            return Save();
        }

        public ICollection<Advertistment> GetAdvertistment()
        {
            return _DbContext.Advertistments.ToList();
        }

        public Advertistment GetAdvertistment(int AdvertistmentId)
        {
            return _DbContext.Advertistments.Where(a => a.ID == AdvertistmentId).FirstOrDefault();
        }

        public bool Save()
        {
            var saved = _DbContext.SaveChanges();
            return saved >= 0 ? true : false;
        }

        public bool UpdateAdvertistment(Advertistment advertistment)
        {
            _DbContext.Update(advertistment);
            return Save();
        }
    }
}
