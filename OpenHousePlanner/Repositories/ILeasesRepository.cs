using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenHousePlanner.DTOs;
using OpenHousePlanner.Models;

namespace OpenHousePlanner.Repositories
{
    public interface ILeasesRepository
    {
        IEnumerable<Lease> GetAllLeases();
        IEnumerable<Lease> GetLeaseById(int id);
        IEnumerable<Lease> AddLease(LeasesDTO newLease);
        Lease UpdateThisLease(int id, Lease updatedLease);
        bool Remove(int id, bool isActive);
    }
}
