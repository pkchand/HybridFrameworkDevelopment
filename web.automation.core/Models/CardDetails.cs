using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobile.automation.core.Models
{
    public class CardDetails
    {
        public string CreditCardNumber { get; set; }
        public string CCType { get; set; }
        public string ExpiryMonth { get; set; }
        public string ExpiryYear { get; set; }
        public string CVV { get; set; }
        public string CountryCode { get; set; }
        public string PayCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
    }
}
