using Abaya_Store.Application.DTOs.Bill;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.MappingProfiles
{
    public class BillProfile : Profile
    {
		public BillProfile()
		{			
			CreateMap<Bill, BillDto>()
				.ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer != null ? $"{src.Customer.FirstName} {src.Customer.LastName}" : null));
			// ممكن ترسل بيانات الشحن لو حابب
			//.ForMember(dest => dest.ShippingAddress, opt => opt.MapFrom(src => src.ShippingInfo != null ? src.ShippingInfo.Address : null));

			CreateMap<CreateBillDto, Bill>();
			CreateMap<UpdateBillDto, Bill>();
		}
	}
}
