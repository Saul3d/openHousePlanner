using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenHousePlanner.Models;

namespace OpenHousePlanner.Repositories
{
    public interface IRentersRepository
    {
        IEnumerable<Renter> GetAllRenters();
        Renter GetRentersById(int id);
        Renter GetRentersByEmail(string email);
    }
}
