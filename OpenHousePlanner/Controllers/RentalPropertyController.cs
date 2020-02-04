using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OpenHousePlanner.DTOs;
using OpenHousePlanner.Repositories;

namespace OpenHousePlanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalPropertyController : ControllerBase
    {
        private readonly ILogger<RentalPropertyController> _logger;
        private readonly IRentalPropertyRepository _repo;

        public RentalPropertyController(ILogger<RentalPropertyController> logger, IRentalPropertyRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        // GET: api/RentalProperty
        [HttpGet]
        public IEnumerable<RentalPropertyDTO> GetAll()
        {
            return _repo.GetAllRentalProperty();
        }

        [HttpGet("{id}")]
        public ActionResult <RentalProperty> GetRentalProperty(int id)
        {
            return _repo.GetRentalPropertyById(id);
        }

        [HttpPost]
        public IActionResult CreateNewRentalProperty(RentalProperty newRentalProperty)
        {
            var addNewRentalProperty = _repo.AddNewRentalProperty(newRentalProperty);
            return Ok(newRentalProperty);

        }

        [HttpPut("{id}")]
        public IActionResult UpdateThisRentalProperty(int id, RentalProperty updatesForRentalProperty)
        {
            var updatedRentalProperty = _repo.UpdateThisRentalProperty(id, updatesForRentalProperty);
            return Ok(updatedRentalProperty);
        }

        [HttpDelete]
        public IActionResult DeleteRentalProperty(int id, bool isActive)
        {
            _repo.Remove(id, isActive);
            return Ok();
        }
    }
}
