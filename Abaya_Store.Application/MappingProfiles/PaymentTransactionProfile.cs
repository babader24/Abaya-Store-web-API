using Abaya_Store.Application.DTOs.PaymentTransaction;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.MappingProfiles
{
	public class PaymentTransactionProfile : Profile
	{
		public PaymentTransactionProfile()
		{
			CreateMap<PaymentTransaction, PaymentTransactionListDto>();

			CreateMap<PaymentTransaction, PaymentTransactionDto>()
				.ForMember(dest => dest.Bill, opt => opt.MapFrom(src => src.Bill));

			CreateMap<PaymentTransactionCreateDto, PaymentTransaction>();
			CreateMap<PaymentTransactionUpdateDto, PaymentTransaction>();
		}
	}

}
