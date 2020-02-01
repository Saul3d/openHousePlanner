using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpenHousePlanner.DTOs;
using OpenHousePlanner.Models;

namespace OpenHousePlanner.Repositories
{
    public interface ITenantsRepository
    {
        IEnumerable<Tenant> GetAllTenants();
        IEnumerable<Tenant> GetTenantById(int id);
        Tenant GetTenantsByEmail(string email);
        IEnumerable<Tenant> AddTenants(TenantsDTO newTenant);
        bool Remove(int id, bool isActive);
    }
}
