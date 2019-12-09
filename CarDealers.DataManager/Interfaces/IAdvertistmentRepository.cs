using CarDealers.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealers.DataManager.Interfaces
{
    public interface IAdvertistmentRepository
    {
        ICollection<Advertistment> GetAdvertistment();
        Advertistment GetAdvertistment(int AdvertistmentId);
        bool AdvertistmentExists(int AdvertistmentId);
        bool CreateAdvertistment(Advertistment advertistment);
        bool UpdateAdvertistment(Advertistment advertistment);
        bool DeleteAdvertistment(Advertistment advertistment);
        bool Save();
    }
}
