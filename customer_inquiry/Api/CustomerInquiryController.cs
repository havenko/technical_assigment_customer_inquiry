using AutoMapper;
using customer_inquiry.BL;
using customer_inquiry.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace customer_inquiry.Api
{
    [Route("api/customer-inquiry")]
    public class CustomerInquiryController : BaseController
    {
        private readonly IMapper mapper;
        private readonly ICustomerBL customerBL;

        public CustomerInquiryController(IMapper mapper, ICustomerBL customerBL)
        {
            this.mapper = mapper;
            this.customerBL = customerBL;
        }

        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(CustomerInquiryResponseDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult Get(int? customerID, string email)
        {
            if(!customerID.HasValue && String.IsNullOrWhiteSpace(email))
            {
                return BadRequest("No inquiry criteria");
            }

            var customer = customerBL.GetCustomer(customerID, email);
            if(customer == null)
            {
                return NotFound("Not found");
            }
            var result = mapper.Map<CustomerInquiryResponseDto>(customer);
            return Ok(result);
        }
    }
}
