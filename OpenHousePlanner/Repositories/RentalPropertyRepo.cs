using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using OpenHousePlanner.DTOs;
using OpenHousePlanner.Models;
using OpenHousePlanner.Repositories;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace OpenHousePlanner.Repositories
{
    public class RentalPropertyRepo : IRentalPropertyRepository
    {
        private readonly string _connectionString;

        public RentalPropertyRepo(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("OpenHousePlanner");
        }

        public IEnumerable<RentalPropertyDTO> GetAllRentalProperty()
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var RentalProperty = db.Query<RentalPropertyDTO>(@"Select * from Rentals");
                return RentalProperty.ToList();
            }
        }

        public RentalProperty GetRentalPropertyById(int id)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"Select *
                            from Rentals
                            where Rentals.id = @RentalId";
                var RentalProperty = db.QueryFirst<RentalProperty>(sql, new {RentalId = id});
                return RentalProperty;
            }
        }

        public RentalProperty AddNewRentalProperty(RentalProperty newRentalProperty)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"INSERT INTO [Rentals]
                          ([Street]
                          ,[City]
                          ,[State]
                          ,[Zip]
                          ,[Bedrooms]
                          ,[Baths]
                          ,[Sqft]
                          ,[HasTenants]
                          ,[IsActive]
                          ,[imgUrl]
                          )
                          output inserted.*
                          VALUES
                          (@Street
                          ,@City
                          ,@State
                          ,@Zip
                          ,@Bedrooms
                          ,@Baths
                          ,@Sqft
                          ,@HasTenants
                          ,@IsActive)
                          ,@imgUrl";

                return db.QueryFirst<RentalProperty>(sql, newRentalProperty);
            }
        }

        public RentalProperty UpdateThisRentalProperty(int id, RentalProperty updatesForRentalProperty)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"UPDATE [dbo].[Rentals]
                          SET
                          [Street] = @Street
                          ,[City] = @City
                          ,[State] = @State
                          ,[Zip] = @Zip
                          ,[Bedrooms] = @Bedrooms
                          ,[Baths] = @Baths
                          ,[Sqft]= @Sqft
                          ,[HasTenants] = @HasTenants
                          ,[IsActive] = @IsActive
                          ,[imgUrl] = @imgUrl
                          
                          output inserted.*
                          WHERE id = @id";

                updatesForRentalProperty.Id = id;

                var newUpdatedRentalProperty = db.QueryFirst<RentalProperty>(sql, updatesForRentalProperty);

                return newUpdatedRentalProperty;
            }
        }

        public bool Remove(int id, bool isActive)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"UPDATE [dbo].[Rentals]
                          SET
                          [isActive] = @isActive
                          WHERE id = @id";

                return db.Execute(sql, new {id, isActive}) == 1;
            }
        }
    }
}
