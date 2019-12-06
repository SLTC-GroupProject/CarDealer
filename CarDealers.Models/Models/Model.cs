using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealers.Models.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public ICollection<Brand> BandId { get; set; }
    }
}
