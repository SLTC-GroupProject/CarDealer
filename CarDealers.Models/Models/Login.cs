using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarDealers.Models.Models
{
    public class Login
    {
        public int Id { get; set; }
        public string  UserName { get; set; }
        public string Password { get; set; }
        public ICollection<User> UserID { get; set; }

    }
}
