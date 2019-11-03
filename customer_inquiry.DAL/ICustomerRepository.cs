using customer_inquiry.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_inquiry.DAL
{
    public interface ICustomerRepository : IBaseRepository
    {
        Customer GetCustomer(int customerID);

        Customer GetCustomer(string email);
    }
}
