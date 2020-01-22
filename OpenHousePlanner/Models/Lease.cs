using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenHousePlanner.Models
{
    public class Lease
    {
        public int Id { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEnd { get; set; }
        public float RentPrice { get; set; }
        public float RentDueDate { get; set; }  
        public Boolean HasPets { get; set; }
        public int DownPayment { get; set; }
        public string Notes { get; set; }
        public string SpouseSSN { get; set; }
        public string priorAddress { get; set; }
    }
}
