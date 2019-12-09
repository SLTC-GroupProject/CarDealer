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


        public void Create(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public ICollection<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(int Id, User user)
        {
            throw new NotImplementedException();
        }
    }
}
