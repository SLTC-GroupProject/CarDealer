using CarDealers.DataManager.Context;
using CarDealers.DataManager.Interfaces;
using CarDealers.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealers.DataManager.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private CarDealersDbContext _DbContext;

        public LocationRepository(CarDealersDbContext DbContext)
        {
            this._DbContext = DbContext;
        }

        public bool CreateLocation(Location location)
        {
            _DbContext.Add(location);
            return Save();
        }

        public bool DeleteLocation(Location location)
        {
            _DbContext.Remove(location);
            return Save();
        }

        public ICollection<Location> GetLocation()
        {
            return _DbContext.Locations.OrderBy(a => a.Id).ToList();
        }

        public Location GetLocation(int LocationId)
        {
            return _DbContext.Locations.Where(a => a.Id == LocationId).FirstOrDefault();
        }

        public bool LocationExists(int LocationId)
        {
            return _DbContext.Locations.Any(a => a.Id == LocationId);
        }

        public bool Save()
        {
            var saved = _DbContext.SaveChanges();
            return saved >= 0 ? true : false;
        }

        public bool UpdateLocation(Location location)
        {
            _DbContext.Update(location);
            return Save();
        }
    }
}
