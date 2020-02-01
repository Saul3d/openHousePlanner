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
    public class LeasesController : ControllerBase
    {
        private readonly ILogger<LeasesController> _logger;
        private readonly ILeasesRepository _repo;

        public LeasesController(ILogger<LeasesController> logger, ILeasesRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Lease> GetAll()
        {
            return _repo.GetAllLeases();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IEnumerable<Lease> GetLease(int id)
        {
            return _repo.GetLeaseById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult CreateNewLease(LeasesDTO newLease)
        {
            newLease.LeaseAgreementDate = DateTime.Today;
            var addNewLease = _repo.AddLease(newLease);
            return Ok(addNewLease);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public IActionResult UpdateThisLease(int id, Lease updatesForLease)
        {
            var updatedLease = _repo.UpdateThisLease(id, updatesForLease);
            return Ok(updatedLease);
        }

        // DELETE api/<controller>?id=<int>&isActive<bool>
        [HttpDelete]
        public IActionResult DeleteLease(int id, bool isActive)
        {
            _repo.Remove(id, isActive);
            return Ok();
        }
    }
}
