using CarDealers.DataManager.Interfaces;
using CarDealers.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CarDealers.DataManager.Context;
using Microsoft.EntityFrameworkCore;

namespace CarDealers.DataManager.Repositories
{
    public class UserRepository : IUserRepository
    {
        private CarDealersDbContext _DbContext;

        public UserRepository(CarDealersDbContext DbContext)
        {
            this._DbContext = DbContext;
        }

        public ICollection<User> GetUser()
        {
            return _DbContext.Users.OrderBy(a => a.ID).ToList();
        }

        public bool UserExists(int UserId)
        {
            return _DbContext.Users.Any(a => a.ID == UserId);
        }

        public bool CreateUser(User user)
        {
            _DbContext.Add(user);
            return Save();
        }

        public User GetUser(int UserId)
        {
            return _DbContext.Users.Where(a => a.ID == UserId).FirstOrDefault();
        }

        public bool DeleteUser(User user)
        {
            _DbContext.Remove(user);
            return Save();
        }

        public bool UpdateUser(User user)
        {
            _DbContext.Update(user);
            return Save();
        }

        public bool Save()
        {
            var saved = _DbContext.SaveChanges();
            return saved >= 0 ? true : false;
        }

        

        
    }
}
