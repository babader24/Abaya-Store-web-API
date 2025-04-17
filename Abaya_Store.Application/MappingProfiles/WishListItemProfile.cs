using Abaya_Store.Application.DTOs.WishListItem;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.MappingProfiles
{
	public class WishListItemProfile : Profile
	{
		public WishListItemProfile()
		{
			CreateMap<WishListItem, WishListItemDto>()
				.ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.Name))
				.ForMember(dest => dest.ProductImage, opt => opt.MapFrom(src => src.Product.Image))
				.ForMember(dest => dest.ProductPrice, opt => opt.MapFrom(src => src.Product.UnitPrice));

			CreateMap<WishListItem, WishListItemBriefDto>()
				.ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.Name));

			CreateMap<WishListItemCreateDto, WishListItem>();
		}
	}

}
