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

        public IEnumerable<User> AddUsers(NewUsersDTO newUsers)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"INSERT INTO [Users]
                          ([FName]
                          ,[MInitial]
                          ,[LName]
                          ,[Phone]
                          ,[Street]
                          ,[City]
                          ,[State]
                          ,[Zip]
                          ,[Email]
                          ,[CreditCardNumber]
                          ,[ExpirationDate]
                          ,[SecurityCode]
                          ,[isActive]
                          )
                          output inserted.*
                          VALUES
                          (@FName
                          ,@MInitial
                          ,@LName
                          ,@Phone
                          ,@Street
                          ,@City
                          ,@State
                          ,@Zip
                          ,@Email
                          ,@CreditCardNumber
                          ,@ExpirationDate
                          ,@SecurityCode
                          ,@isActive)";
                return db.Query<User>(sql, newUsers);
            }
        }
        public User GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public User UpdateThisUser(int id, User updatesForUser)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"UPDATE [dbo].[Users]
                          SET
                          [FName] = @FName
                          ,[MInitial] = @MInitial
                          ,[LName] = @LName
                          ,[Phone] = @Phone
                          ,[Street] = @Street
                          ,[City] = @City
                          ,[State] = @State
                          ,[Zip] = @Zip
                          ,[Email] = @Email
                          ,[CreditCardNumber] = @CreditCardNumber
                          ,[ExpirationDate] = @ExpirationDate
                          ,[SecurityCode] = @SecurityCode
                          ,[isActive] = @isActive

                          output inserted.*
                          WHERE id = @id";

                updatesForUser.Id = id;

                var newUpdatedUser = db.QueryFirst<User>(sql, updatesForUser);
                
                return newUpdatedUser;
            }
        }

        public bool Remove(int id, bool isActive)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"UPDATE [dbo].[Users]
                            SET
                            [isActive] = @isActive
                            WHERE id = @id";

                return db.Execute(sql, new {id, isActive}) == 1;
            }
        }

    }
}
