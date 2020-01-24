using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenHousePlanner.Models
{
    public class Renter: PersonBase
    {
        public string Gender { get; set; }
        public Array References { get; set; }
        public string SSN { get; set; }
        public string SpouseFName { get; set; }
        public string SpouseLName { get; set; }
        public string CreditCardNum { get; set; }
        public string Adults { get; set; }
        public string Children { get; set; }
        public string Pets { get; set; }
        public string Occupants { get; set; }
        public string OccupancyLength { get; set; }
        public string PreviousAddress { get; set; }
        public int MonthlyIncome { get; set; }
        public string EmployerAddress { get; set; }
        public string EmployerPhoneNumber { get; set; }
        public string EmploymentLength { get; set; }
        public string CurrentLandLord { get; set; }
        public string CurrentLandlordPhone { get; set; }
    }
}
