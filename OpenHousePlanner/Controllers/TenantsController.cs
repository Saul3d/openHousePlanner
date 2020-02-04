using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OpenHousePlanner.DTOs;
using OpenHousePlanner.Models;
using OpenHousePlanner.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OpenHousePlanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantsController : ControllerBase
    {
        private readonly ILogger<TenantsController> _logger;
        private readonly ITenantsRepository _repo;

        public TenantsController(ILogger<TenantsController> logger, ITenantsRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Tenant> GetAll()
        {
            return _repo.GetAllTenants();
        }

        [HttpGet("{id}")]
        public IEnumerable<Tenant> GetUser(int id)
        {
            return _repo.GetTenantById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult CreateTenant(TenantsDTO newTenant)
        {
            newTenant.Dob = DateTime.Today;
            var addNewTenant = _repo.AddTenants(newTenant);
            return Ok(addNewTenant);
        }

        // PUT api/<controller/5
        [HttpPut("{id}")]
        public IActionResult UpdateThisTenant(int id, Tenant updatesForTenant)
        {
            updatesForTenant.Dob = DateTime.Today;
            var updatedTenants = _repo.UpdateThisTenant(id, updatesForTenant);
            return Ok(updatedTenants);
        }

        // Post api/<controller>?id=<int>&isActive<bool>
        [HttpDelete]
        public IActionResult DeleteTenant(int id, bool isActive)
        {
            _repo.Remove(id, isActive);
            return Ok();
        }
    }
}
