using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenHousePlanner.Repositories;

namespace OpenHousePlanner.Models
{
    public class User: PersonBase
    {
        public bool isActive { get; set; }
        public string CreditCardNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string SecurityCode { get; set; }

    }
}
