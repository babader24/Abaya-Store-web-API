using Abaya_Store.Application.DTOs.Category;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.MappingProfiles
{
	public class CategoryProfile : Profile
	{
		public CategoryProfile()
		{
			CreateMap<Category, CategoryListDto>();

			CreateMap<Category, CategoryDto>()
				.ForMember(dest => dest.ProductNames, opt => opt.MapFrom(src =>
					src.Products.Select(p => p.Name).ToList()));

			CreateMap<CategoryCreateDto, Category>();
			CreateMap<CategoryUpdateDto, Category>();
		}
	}

}
