using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpenHousePlanner.DTOs;
using OpenHousePlanner.Models;

namespace OpenHousePlanner.Repositories
{
    public interface IRentersRepository
    {
        IEnumerable<Renter> GetAllRenters();
        IEnumerable<Renter> GetRentersById(int id);
        Renter GetRentersByEmail(string email);
        IEnumerable<Renter> AddRenter(RentersDTO newRenter);
    }
}
