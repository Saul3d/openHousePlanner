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
    public class RentersController : Controller
    {
        private readonly ILogger<RentersController> _logger;
        private readonly IRentersRepository _repo;

        public RentersController(ILogger<RentersController> logger, IRentersRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Renter> GetAll()
        {
            return _repo.GetAllRenters();
        }

        [HttpGet("{id}")]
        public IEnumerable<Renter> GetUser(int id)
        {
            return _repo.GetRentersById(id);
        }

        // POST api/values
        [HttpPost]
        public IActionResult CreateNewRenter(RentersDTO addNewRenter)
        {
            var newRenter = new Renter
            {
                FName = addNewRenter.FName,
                LName = addNewRenter.LName,
                Email = addNewRenter.Email,
                Phone = addNewRenter.Phone,
                Notes = addNewRenter.Notes
            };

        }
    }
}
