using Abaya_Store.Application.DTOs.Customer;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.MappingProfiles
{
	public class CustomerProfile : Profile
	{
		public CustomerProfile()
		{
			CreateMap<Customer, CustomerListDto>()
				.ForMember(dest => dest.FullName, opt =>
					opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));

			CreateMap<Customer, CustomerDto>()
				.ForMember(dest => dest.BillNumbers, opt =>
					opt.MapFrom(src => src.Bills.Select(b => b.BillNumber).ToList()))
				.ForMember(dest => dest.ReviewSummaries, opt =>
					opt.MapFrom(src => src.Reviews.Select(r => r.Comment).ToList())); 

			CreateMap<CustomerCreateDto, Customer>();
			CreateMap<CustomerUpdateDto, Customer>();
		}
	}

}
