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
        public Expense GetExpenseById(int id)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"select * 
                            from Expenses
                            where Expenses.Id = @expenseId";
                var expense = db.QueryFirst<Expense>(sql, new { expenseId = id });
                return expense;
            }

        }

        public IEnumerable<Expense> AddExpense(ExpensesDTO newExpense)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"INSERT INTO [Expenses]
                                       ([expenseName]
                                        ,[cost]
                                        ,[purchaseDate]
                                        ,[category]
                                        ,[rentalId]
                                         )
                                         output inserted.*
                                        VALUES
                                        (@expenseName
                                        ,@cost
                                        ,@purchaseDate
                                        ,@category
                                        ,@rentalId)";
                return db.Query<Expense>(sql, newExpense);
            }
        }

        public Expense UpdateThisExpense(int id, Expense updatesForExpense)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"UPDATE [dbo].[Expenses]
                            SET
                                [expenseName] = @expenseName
                                ,[cost] = @cost
                                ,[purchaseDate] = @purchaseDate
                                ,[category] = @category
                                ,[rentalId] = @rentalId   

                            output inserted.*
                            WHERE id = @id";

                updatesForExpense.Id = id;
                
                var newUpdatedExpenses = db.QueryFirst<Expense>(sql, updatesForExpense);
                
                return newUpdatedExpenses;
            }
        }

        public bool Remove(int id)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"delete
                            from Expenses 
                            where id = @id";

                return db.Execute(sql, new { id }) == 1;

            }
        }

    }
}
