using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenHousePlanner.Models
{
    public class Renter
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string MInitial { get; set; }
        public string LName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PreviousAddress { get; set; }
        public int MonthlyIncome { get; set; }
        public string Employer { get; set; }
        public string EmployerAddress { get; set; }
        public string EmployerPhoneNumber { get; set; }
        public string EmploymentLength { get; set; }
        public Array References { get; set; }
        public string SSN { get; set; }
        public string SpouseSSN { get; set; }


    }
}
