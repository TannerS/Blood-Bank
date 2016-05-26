using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS408Project
{
    public class Donors
    {
        public string ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public short Age { get; set; }
        // true = male, false = female
        public String Sex { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        // true = positive, false = negative
        public String Rh { get; set; }
        // in liters
        public short BloodAmount { get; set; }
        public string BloodType { get; set; }
    }
}
