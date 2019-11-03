using customer_inquiry.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_inquiry.Data
{
    public class Seeder
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                ID = 123456,
                Name = "Firstname1 Lastname1",
                Email = "user1@domain.com",
                MobileNo = "0123456789"
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                ID = 123457,
                Name = "Firstname2 Lastname2",
                Email = "user2@domain.com",
                MobileNo = "0123456788"
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                ID = 123458,
                Name = "Firstname3 Lastname3",
                Email = "user3@domain.com",
                MobileNo = "0123456787"
            });

            modelBuilder.Entity<Transaction>().HasData(new Transaction
            {
                ID = 1,
                Timestamp = new DateTime(2018, 2, 28, 21, 34, 0),
                CustomerID = 123457,
                Amount = 1234.56M,
                CurrencyCode = Domain.Enums.CurrencyCode.USD,
                Status = Domain.Enums.Status.Success
            });

            modelBuilder.Entity<Transaction>().HasData(new Transaction
            {
                ID = 2,
                Timestamp = new DateTime(2018, 2, 28, 21, 34, 0),
                CustomerID = 123458,
                Amount = 1234.56M,
                CurrencyCode = Domain.Enums.CurrencyCode.USD,
                Status = Domain.Enums.Status.Success
            });

            modelBuilder.Entity<Transaction>().HasData(new Transaction
            {
                ID = 3,
                Timestamp = new DateTime(2018, 1, 11, 8, 34, 0),
                CustomerID = 123458,
                Amount = 0.56M,
                CurrencyCode = Domain.Enums.CurrencyCode.THB,
                Status = Domain.Enums.Status.Failed
            });
        }
    }
}
