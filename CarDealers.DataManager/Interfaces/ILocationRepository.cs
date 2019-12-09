using CarDealers.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealers.DataManager.Interfaces
{
    public interface ILocationRepository
    {
        ICollection<Location> GetLocation();
        Location GetLocation(int LocationId);
        bool LocationExists(int LocationId);
        bool CreateLocation(Location location);
        bool UpdateLocation(Location location);
        bool DeleteLocation(Location location);
        bool Save();
    }
}
