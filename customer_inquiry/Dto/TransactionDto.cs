using customer_inquiry.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_inquiry.Dto
{
    public class TransactionDto
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public string Currency { get; set; }

        public string Status { get; set; }        
    }
}
