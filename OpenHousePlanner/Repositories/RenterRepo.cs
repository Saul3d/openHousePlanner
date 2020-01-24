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

        public Renter AddNewRenters(RentersDTO newRenter)
        {
            using (var db = new SqlConnection(_connectionString))

            {
                var sql = @"INSERT INTO Renters
                                       ([fName]
                                       ,[lName]
                                       ,[Email]
                                       ,[Phone] 
                                       ,[ImgUrl]
                                       ,[Bio]
                                                )
                                    output inserted.*
                                    VALUES
                                       (@fname
                                       ,@lname
                                       ,@email
                                       ,@phone)";
                return db.QueryFirst<Renter>(sql, newRenter);
            }
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

                var renter = db.Query<Renter>(sql, new { renterId = id });
                return renter;
            }
        }

        public Renter GetRentersByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
