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
        public int ID { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(25)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$")]
        public string Email { get; set; }

        [StringLength(10)]
        public string MobileNo { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
