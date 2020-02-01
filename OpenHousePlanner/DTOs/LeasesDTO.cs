using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenHousePlanner.DTOs
{
    public class LeasesDTO
    {
        public DateTime LeaseAgreementDate { get; set; }
        public DateTime LeaseStartDate { get; set; }
        public DateTime RentDueDate { get; set; }
        public float RentalFee { get; set; }
        public int RentalId { get; set; }
        public bool HasPet { get; set; }
        public float PetFee { get; set; }
        public float SecurityDeposit { get; set; }
        public string BankNameForDeposit { get; set; }
        public int TenantId { get; set; }
        public float LateFee { get; set; }
        public bool HoldOver { get; set; }
        public float HoldOverFee { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
    }
}
