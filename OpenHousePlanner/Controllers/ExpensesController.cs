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
        [HttpGet("{id}")]
        public Expense GetExpense(int id)
        {
            return _repo.GetExpenseById(id);
        }

        // POST: api/Expenses
        [HttpPost]
        public IActionResult CreateNewExpense(ExpensesDTO newExpense)
        {
            newExpense.purchaseDate = DateTime.Today;
            var addNewExpense = _repo.AddExpense(newExpense);
            return Ok(addNewExpense);
        }

        // PUT: api/Expenses/5
        [HttpPut("{id}")]
        public IActionResult UpdateThisExpense(int id, Expense updatesForExpense)
        {
            var updatedExpense = _repo.UpdateThisExpense(id, updatesForExpense);
            return Ok(updatedExpense);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult DeleteExpense(int id)
        {
            _repo.Remove(id);

            return Ok();
        }
    }
}
