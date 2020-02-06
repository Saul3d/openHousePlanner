using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenHousePlanner.DTOs
{
    public class RentalPropertyDTO
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int Bedrooms { get; set; }
        public int Baths { get; set; }
        public int Sqft { get; set; }
        public bool HasTenants { get; set; }
        public bool IsActive { get; set; }
        public string ImgUrl { get; set; }
    }
}
