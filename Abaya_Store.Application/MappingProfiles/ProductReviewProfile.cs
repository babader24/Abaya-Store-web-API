using Abaya_Store.Application.DTOs.ProductReview;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.MappingProfiles
{
	public class ProductReviewProfile : Profile
	{
		public ProductReviewProfile()
		{
			CreateMap<ProductReview, ProductReviewListDto>();
			CreateMap<ProductReview, ProductReviewDto>();
			CreateMap<ProductReviewCreateDto, ProductReview>();
			CreateMap<ProductReviewUpdateDto, ProductReview>();
		}
	}

}
