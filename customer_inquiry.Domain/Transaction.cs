using customer_inquiry.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_inquiry.Domain
{
    public class Transaction
    {
        public int ID { get; set; }

        public int CustomerID { get; set; }

        public DateTime Timestamp { get; set; }

        public decimal Amount { get; set; }

        public CurrencyCode CurrencyCode { get; set; }

        public Status Status { get; set; }
    }
}
