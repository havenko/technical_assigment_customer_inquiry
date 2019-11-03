using AutoMapper;
using customer_inquiry.Domain;
using customer_inquiry.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_inquiry.Profiles
{
    public class CustomerInquiryProfile : Profile
    {
        public CustomerInquiryProfile()
        {
            CreateMap<Customer, CustomerInquiryResponseDto>()
                .ForMember(x => x.CustomerID, opt => opt.MapFrom(p => p.ID))
                .ForMember(x => x.Mobile, opt => opt.MapFrom(p => p.MobileNo));
        }
    }
}
