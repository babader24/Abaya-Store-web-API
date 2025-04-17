using Abaya_Store.Application.DTOs.CartItem;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.MappingProfiles
{
	public class CartItemProfile : Profile
	{
		public CartItemProfile()
		{
			CreateMap<CartItem, CartItemDto>()
				.ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.Name));

			CreateMap<CartItem, CartItemListDto>()
				.ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.Name));

			CreateMap<CartItemCreateDto, CartItem>();
			CreateMap<CartItemUpdateDto, CartItem>();
		}
	}
}
