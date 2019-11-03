using customer_inquiry.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_inquiry.Data
{
    public class CustomerInquiryDbContext : DbContext, ICustomerInquiryDbContext
    {
        public CustomerInquiryDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(local);Initial Catalog=customer_inquiry;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(options);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            var seeder = new Seeder();
            seeder.Seed(modelBuilder);
        }

    }
}
