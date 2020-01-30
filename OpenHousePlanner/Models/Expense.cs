using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenHousePlanner.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string expenseName { get; set; }
        public float cost { get; set; }
        public DateTime purchaseDate { get; set; }
        public string category { get; set; }
        public int rentalId { get; set; }
    }
}
