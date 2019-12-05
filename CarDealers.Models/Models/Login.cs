using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarDealers.Models.Models
{
    public class Login
    {
        public int LoginId { get; set; }
        public string  LoginUserName { get; set; }
        public string LoginPassword { get; set; }
        public ICollection<User> UserID { get; set; }

    }
}
