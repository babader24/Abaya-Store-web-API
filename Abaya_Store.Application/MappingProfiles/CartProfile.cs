using Abaya_Store.Application.DTOs.Cart;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.MappingProfiles
{
	public class CartProfile : Profile
	{
		public CartProfile()
		{
			CreateMap<Cart, CartListDto>()
				.ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => $"{src.Customer.FirstName} {src.Customer.LastName}"))
				.ForMember(dest => dest.ItemCount, opt => opt.MapFrom(src => src.Items.Count));

			CreateMap<Cart, CartDto>()
				.ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => $"{src.Customer.FirstName} {src.Customer.LastName}"));

			CreateMap<CartDto, Cart>();

		}
	}
}
