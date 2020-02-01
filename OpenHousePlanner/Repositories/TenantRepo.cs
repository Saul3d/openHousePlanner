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
    public class TenantRepo : ITenantsRepository
    {
        private readonly string _connectionString;

        public TenantRepo(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("OpenHousePlanner");
        }

        public IEnumerable<Tenant> GetAllTenants()
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var renters = db.Query<Tenant>(@"Select * from Tenants");
                return renters.ToList();
            }
        }

        public IEnumerable<Tenant> GetTenantById(int id)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"select *
                            from Tenants
                            where Tenants.Id = @tenantId";

                var renter = db.Query<Tenant>(sql, new {tenantId = id});
                return renter;
            }
        }

        public Tenant GetTenantsByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tenant> AddTenants(TenantsDTO newTenant)
        {
            using (var db = new SqlConnection(_connectionString))

            {
                var sql = @"INSERT INTO [Tenants]
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
                                       ,[IsActive]
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
                                       ,@Notes)
                                       ,@IsActive";

                return db.Query<Tenant>(sql, newTenant);
            }
        }
        public bool Remove(int id, bool isActive)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"UPDATE [dbo].[Tenants]
                            SET
                            [isActive] = @isActive
                            WHERE id = @id";

                return db.Execute(sql, new { id, isActive }) == 1;
            }

        }
    }
}
