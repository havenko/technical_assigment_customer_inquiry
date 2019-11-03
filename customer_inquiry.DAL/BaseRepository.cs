using customer_inquiry.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_inquiry.DAL
{
    public class BaseRepository : IBaseRepository
    {
        protected readonly CustomerInquiryDbContext context;

        public BaseRepository(CustomerInquiryDbContext context)
        {
            this.context = context;
        }
    }
}
