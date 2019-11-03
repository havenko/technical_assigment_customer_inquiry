using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_inquiry.Domain
{
    public class Customer
    {
        [Range(1, 1000000000)]
        public int ID { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(25)]
        public string Email { get; set; }

        [StringLength(10)]
        public string MobileNo { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
