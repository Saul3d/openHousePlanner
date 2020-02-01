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
    public class leaseRepo : ILeasesRepository
    {
        private readonly string _connectionString;

        public leaseRepo(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("OpenHousePlanner");
        }

        public IEnumerable<Lease> GetAllLeases()
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var leases = db.Query<Lease>(@"Select * from Leases");
                return leases.ToList();
            }
        }

        public IEnumerable<Lease> GetLeaseById(int id)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"select * 
                            from Leases
                            where Leases.Id = @leaseId";
                var lease = db.Query<Lease>(sql, new {leaseId = id});
                return lease;
            }

        }

        public IEnumerable<Lease> AddLease(LeasesDTO newLease)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"INSERT INTO [Leases]
                                        ([leaseAgreementDate]
                                        ,[leaseStartDate]
                                        ,[rentalFee]
                                        ,[rentDueDate]
                                        ,[userId]
                                        ,[hasPet]
                                        ,[petFee]
                                        ,[rentalId]
                                        ,[securityDeposit]
                                        ,[bankNameForDeposit]
                                        ,[tenantId]
                                        ,[lateFee]
                                        ,[holdOver]
                                        ,[holdOverFee]
                                        ,[Notes]
                                        )
                                        output inserted.*
                                        VALUES
                                        (@leaseAgreementDate
                                        ,@leaseStartDate
                                        ,@rentalFee
                                        ,@rentDueDate
                                        ,@userId
                                        ,@hasPet
                                        ,@petFee
                                        ,@rentalId
                                        ,@securityDeposit
                                        ,@bankNameForDeposit
                                        ,@tenantId
                                        ,@lateFee
                                        ,@holdOver
                                        ,@holdOverFee
                                        ,@Notes)";
                return db.Query<Lease>(sql, newLease);
            }
        }
        public Lease UpdateThisLease(int id, Lease updatesForLease)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"UPDATE [dbo].[Leases]
                            SET
                             [leaseAgreementDate] = @leaseAgreementDate
                            ,[leaseStartDate] = @leaseStartDate
                            ,[rentalFee] = @rentalFee
                            ,[rentDueDate] = @rentDueDate
                            ,[hasPet] = @hasPet
                            ,[rentalId] = @rentalId
                            ,[securityDeposit] = @securityDeposit
                            ,[bankNameForDeposit] = @bankNameForDeposit
                            ,[lateFee] = @lateFee
                            ,[holdOver] = @holdOver
                            ,[holdOverFee] = @holdOverFee
                            ,[Notes] = @Notes

                             output inserted.*
                             WHERE id = @id";
                
                updatesForLease.Id = id;

                var newUpdatedLease = db.QueryFirst<Lease>(sql, updatesForLease);
                
                return newUpdatedLease;
            }

        }
        public bool Remove(int id, bool isActive)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sql = @"UPDATE [dbo].[Leases]
                            SET
                            [isActive] = @isActive
                            WHERE id = @id";

                return db.Execute(sql, new { id, isActive }) == 1;
            }

        }

    }
}

