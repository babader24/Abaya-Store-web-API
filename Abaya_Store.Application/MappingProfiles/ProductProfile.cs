using Abaya_Store.Application.DTOs.Product;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.MappingProfiles
{
	public class ProductProfile : Profile
	{
		public ProductProfile()
		{
			CreateMap<Product, ProductListDto>();
			CreateMap<Product, ProductDto>()
				.ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
				.ForMember(dest => dest.Offer, opt => opt.MapFrom(src => src.Offer));

			CreateMap<ProductCreateDto, Product>();
			CreateMap<ProductUpdateDto, Product>();
		}
	}

}
