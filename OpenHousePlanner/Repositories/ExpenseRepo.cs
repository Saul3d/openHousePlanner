using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using OpenHousePlanner.DTOs;
using OpenHousePlanner.Models;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace OpenHousePlanner.Repositories
{
    public class ExpenseRepo : IExpensesRepository
    {
        private readonly string _connectionString;

        public ExpenseRepo(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("OpenHousePlanner");
        }

        public IEnumerable<Expense> GetAllExpenses()
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var expenses = db.Query<Expense>(@"Select * from Expenses");
                return expenses.ToList();
            }
        }

    }
}
