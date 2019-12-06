using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealers.Models.Models
{
    public class Advertistment
    {
        public int ID { get; set; }
        public string AdTitle { get; set; }
        public string AdData { get; set; }
        public string AdPrice { get; set; }
        public string AdDescription { get; set; }
        public string AdImage { get; set; }
        public string VehEnginCapacity { get; set; }
        public string VehiMilage { get; set; }
        public DateTime VehiYear { get; set; }
        public string VehiGrade { get; set; }
        public string VehiFuelType { get; set; }
        public string VehiCondition { get; set; }
        public string VehiBodyType { get; set; }
        public string VehiTransmission { get; set; }
        public string VehiEdition { get; set; }
        public string LocLongitude{ get; set; }
        public string LocLatitude { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserMobileno { get; set; }
        public ICollection<User> UserId { get; set; }
    }
}
