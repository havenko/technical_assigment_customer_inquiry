using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using customer_inquiry.DAL;
using customer_inquiry.Domain;

namespace customer_inquiry.BL
{
    public class CustomerBL : ICustomerBL
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerBL(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        public Customer GetCustomer(int? customerID, string email)
        {
            if(customerID.HasValue)
            {
                return customerRepository.GetCustomer(customerID.Value);
            }
            else
            {
                return customerRepository.GetCustomer(email);
            }
        }
    }
}
