using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenHousePlanner.DTOs;
using OpenHousePlanner.Models;

namespace OpenHousePlanner.Repositories
{
    public interface IRentalPropertyRepository
    {
        IEnumerable<RentalPropertyDTO> GetAllRentalProperty();
        RentalProperty GetRentalPropertyById(int id);
        RentalProperty AddNewRentalProperty(RentalProperty newRentalProperty);
        RentalProperty UpdateThisRentalProperty(int id, RentalProperty updatesForRentalProperty);
        bool Remove(int id, bool isActive);
    }
}
