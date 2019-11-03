using customer_inquiry.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_inquiry.BL
{
    public interface ICustomerBL : IBaseBL
    {
        Customer GetCustomer(int? customerID, string email);
    }
}
