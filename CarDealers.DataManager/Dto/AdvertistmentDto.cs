using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealers.DataManager.Dto
{
    public class AdvertistmentDto
    {       
        public string AdTitle { get; set; }
        public string AdPrice { get; set; }
        public string AdImage { get; set; }
        public int LocationId { get; set; }
        public int CategoryId { get; set; }
        public int ModelId { get; set; }
        public int BrandId { get; set; }
    }
}
