using CarDealers.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace CarDealers.DataManager.Interfaces
{
    public interface IUserRepository
    {
        ICollection<User> GetUser();
        User GetUser(int UserId);
        bool UserExists(int UserId);
        bool CreateUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(User user);
        bool Save();
    }
}
