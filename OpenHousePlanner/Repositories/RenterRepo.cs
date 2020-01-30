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
    public class RenterRepo : IRentersRepository
    {
        private readonly string _connectionString;

        public RenterRepo(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("OpenHousePlanner");
        }

        public IEnumerable<Renter> GetAllRenters()
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var renters = db.Query<Renter>(@"Select * from Renters");
                return renters.ToList();
            }
        }

        public IEnumerable<Renter> GetRentersById(int id)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"select *
                            from Renters
                            where Renters.Id = @renterId";

                var renter = db.Query<Renter>(sql, new {renterId = id});
                return renter;
            }
        }

        public Renter GetRentersByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Renter> AddRenter(RentersDTO newRenter)
        {
            using (var db = new SqlConnection(_connectionString))

            {
                var sql = @"INSERT INTO [Renters]
                                       ([FName]
                                       ,[LName]
                                       ,[Phone]
                                       ,[Street]
                                       ,[City]
                                       ,[State]
                                       ,[Zip]
                                       ,[Email]
                                       ,[DOB]
                                       ,[Notes]
                                                )
                                    output inserted.*
                                    VALUES
                                       (@FName
                                       ,@LName
                                       ,@Phone
                                       ,@Street
                                       ,@City
                                       ,@State
                                       ,@Zip
                                       ,@Email
                                       ,@DOB
                                       ,@Notes)";

                return db.Query<Renter>(sql, newRenter);
            }
        }
    }
}
