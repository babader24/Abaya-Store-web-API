using Abaya_Store.Application.DTOs.WishList;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.MappingProfiles
{
	public class WishListProfile : Profile
	{
		public WishListProfile()
		{
			CreateMap<WishList, WishListDto>();
			CreateMap<WishList, WishListListDto>();
			CreateMap<WishListCreateDto, WishList>();
		}
	}

}
