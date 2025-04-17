using Abaya_Store.Application.DTOs.ShippingInfo;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.MappingProfiles
{
	public class ShippingInfoProfile : Profile
	{
		public ShippingInfoProfile()
		{
			CreateMap<ShippingInfo, ShippingInfoDto>();
			CreateMap<ShippingInfo, ShippingInfoListDto>();
			CreateMap<ShippingInfoCreateDto, ShippingInfo>();
			CreateMap<ShippingInfoUpdateDto, ShippingInfo>();
		}
	}

}
