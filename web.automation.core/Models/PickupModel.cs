using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobile.automation.core.Models
{
    public class PickupModel
    {
        public string FreightCode { get; set; }
        public string WarehouseCode { get; set; }
        public string Country { get; set; }
        public string PickUpLocation { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string CountryDistrict { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
    }
}
