using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OpenHousePlanner.DTOs;
using OpenHousePlanner.Models;
using OpenHousePlanner.Repositories;

namespace OpenHousePlanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        private readonly ILogger<ExpensesController> _logger;
        private readonly IExpensesRepository _repo;

        public ExpensesController(ILogger<ExpensesController> logger, IExpensesRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }
        // GET: api/Expenses
        [HttpGet]
        public IEnumerable<Expense> GetAll()
        {
            return _repo.GetAllExpenses();
        }

        // GET: api/Expenses/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Expenses
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Expenses/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
