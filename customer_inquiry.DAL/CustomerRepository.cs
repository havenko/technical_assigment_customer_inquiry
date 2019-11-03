using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using customer_inquiry.Data;
using customer_inquiry.Domain;

namespace customer_inquiry.DAL
{
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public CustomerRepository(CustomerInquiryDbContext context) : base(context)
        {

        }

        public Customer GetCustomer(int customerID)
        {
            var customer = context.Customers.Find(customerID);
            if(customer == null)
            {
                return null;
            }
            context.Entry(customer).Collection(x => x.Transactions).Load();
            return customer;
        }

        public Customer GetCustomer(string email)
        {
            var customer = context.Customers.FirstOrDefault(x => x.Email == email);
            if (customer == null)
            {
                return null;
            }
            context.Entry(customer).Collection(x => x.Transactions).Load();
            return customer;
        }
    }
}
