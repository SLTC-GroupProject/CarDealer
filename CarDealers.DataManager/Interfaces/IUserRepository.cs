using CarDealers.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace CarDealers.DataManager.Interfaces
{
    public interface IUserRepository
    {
        ICollection<User> GetAll();
        User GetById(int Id);
        void Create(User user);
        void Update(int Id, User user);
        void Delete(int Id);
    }
}
