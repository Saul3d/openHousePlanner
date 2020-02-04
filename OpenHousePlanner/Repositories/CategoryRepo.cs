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
    public class CategoryRepo : ICategoryRepository
    {
        private readonly string _connectionString;

        public CategoryRepo(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("OpenHousePlanner");
        }

        public IEnumerable<Categories> GetAllCategories()
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var categories = db.Query<Categories>(@"Select * from Categories");
                return categories.ToList();
            }
        }
    }
}
