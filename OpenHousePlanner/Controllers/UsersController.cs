﻿using System;
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
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly IUsersRepository _repo;

        public UsersController(ILogger<UsersController> logger, IUsersRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return _repo.GetAllUsers();
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            return _repo.GetUserById(id);
        }

        [HttpPost]
        public IActionResult CreateNewUser(NewUsersDTO newUser)
        {
            var addNewUser = _repo.AddUsers(newUser);
            return Ok(addNewUser);
        }
        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public IActionResult UpdateThisUser(int id, User updatesForUser)
        {
            var updatedUser = _repo.UpdateThisUser(id, updatesForUser);
            return Ok(updatedUser);
        }

        // DELETE api/<controller>?id=<int>&isActive<bool>
        [HttpDelete]
        public IActionResult DeleteUser(int id, bool isActive)
        {
            _repo.Remove(id, isActive);
            return Ok();
        }
    }
}
