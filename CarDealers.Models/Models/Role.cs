using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealers.Models.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<User> UserId { get; set; }
    }
}
