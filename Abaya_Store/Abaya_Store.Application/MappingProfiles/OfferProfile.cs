using Abaya_Store.Application.DTOs.Offer;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.MappingProfiles
{
	public class OfferProfile : Profile
	{
		public OfferProfile()
		{
			CreateMap<Offer, OfferListDto>();

			CreateMap<Offer, OfferDto>()
				.ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.Products.Select(p => p.Product)));

			CreateMap<OfferCreateDto, Offer>();
			CreateMap<OfferUpdateDto, Offer>();
		}
	}

}
