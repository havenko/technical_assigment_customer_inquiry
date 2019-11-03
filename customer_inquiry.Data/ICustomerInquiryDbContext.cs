using customer_inquiry.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_inquiry.Data
{
    public interface ICustomerInquiryDbContext
    {
        DbSet<Customer> Customers { get; set; }

        DbSet<Transaction> Transactions { get; set; }

    }
}
