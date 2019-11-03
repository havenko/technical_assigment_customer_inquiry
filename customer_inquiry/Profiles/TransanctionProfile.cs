using AutoMapper;
using customer_inquiry.Domain;
using customer_inquiry.Domain.Enums;
using customer_inquiry.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_inquiry.Profiles
{
    public class TransanctionProfile : Profile
    {
        public TransanctionProfile()
        {
            CreateMap<Transaction, TransactionDto>()
                .ForMember(x => x.Date, opt => opt.MapFrom(p => p.Timestamp))
                .ForMember(x => x.Currency, opt => opt.MapFrom(p => p.CurrencyCode))              
                .ForMember(x => x.Status, opt => opt.MapFrom(p => p.Status));
        }
    }
}
