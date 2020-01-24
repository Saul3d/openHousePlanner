using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenHousePlanner.DTOs
{
    public class RentersDTO
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string MInitial { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
