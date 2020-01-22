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
    public class UserRepo : IUsersRepository
    {
        private readonly string _connectionString;

        public UserRepo(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("OpenHousePlanner");
        }

        public User AddNewUsers(NewUsersDTO newUser)
        {
            using (var db = new SqlConnection(_connectionString))

            {
                var sql = @"INSERT INTO Users
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
                                       ,@phone
                                       ,@imgurl
                                       ,@bio)";
                return db.QueryFirst<User>(sql, newUser);
            }
        }
        public IEnumerable<User> GetAllUsers()
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var users = db.Query<User>(@"Select * from Users");
                return users.ToList();
            }
        }

        public User GetUserById(int id)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"select *
                            from Users
                            where Users.Id = @userId";

                var user = db.QueryFirst<User>(sql, new { userId = id });
                return user;
            }
        }

        public User GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
