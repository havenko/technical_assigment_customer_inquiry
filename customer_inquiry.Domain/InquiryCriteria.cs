using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_inquiry.Domain
{
    public class InquiryCriteria
    {
        [Range(1, 1000000000)]
        public int CustomerID { get; set; }

        [MaxLength(25)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
