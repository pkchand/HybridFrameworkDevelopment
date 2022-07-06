using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobile.automation.core.Models
{
    public class ShippingModel : ICloneable
    {
        public string FreightCode { get; set; }
        public string WarehouseCode { get; set; }
        public string Country { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Suburb { get; set; }
        public string CountryDistrict { get; set; }
        public string Zip { get; set; }
        public string Zip2 { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string Provience { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }

        public virtual object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
