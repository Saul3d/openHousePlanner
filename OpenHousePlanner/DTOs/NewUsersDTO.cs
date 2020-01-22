using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenHousePlanner.DTOs
{
    public class NewUsersDTO
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string MInitial { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string CreditCardNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string SecurityCode { get; set; }
    }
}
