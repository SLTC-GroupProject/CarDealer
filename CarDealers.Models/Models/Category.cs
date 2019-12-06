using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealers.Models.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Advertistment> AdId { get; set; }
    }
}
