using Abaya_Store.Application.DTOs.OfferProduct;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.MappingProfiles
{
	public class OfferProductProfile : Profile
	{
		public OfferProductProfile()
		{
			CreateMap<OfferProduct, OfferProductListDto>()
				.ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.Name));

			CreateMap<OfferProduct, OfferProductDto>()
				.ForMember(dest => dest.Offer, opt => opt.MapFrom(src => src.Offer))
				.ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product));

			CreateMap<OfferProductCreateDto, OfferProduct>();
			CreateMap<OfferProductUpdateDto, OfferProduct>();
		}
	}

}
