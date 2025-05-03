using Abaya_Store.Application.DTOs.OrderDetaile;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.MappingProfiles
{
	public class OrderDetailProfile : Profile
	{
		public OrderDetailProfile()
		{
			CreateMap<OrderDetaile, OrderDetailListDto>()
				.ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.Name));

			CreateMap<OrderDetaile, OrderDetailDto>()
				.ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product))
				.ForMember(dest => dest.Bill, opt => opt.MapFrom(src => src.Bill));

			CreateMap<OrderDetailCreateDto, OrderDetaile>();
			CreateMap<OrderDetailUpdateDto, OrderDetaile>();
		}
	}

}
