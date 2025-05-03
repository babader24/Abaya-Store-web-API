using Abaya_Store.Application.DTOs.NewsletterSubscription;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.MappingProfiles
{
	public class NewsletterSubscriptionProfile : Profile
	{
		public NewsletterSubscriptionProfile()
		{
			CreateMap<NewsletterSubscription, NewsletterSubscriptionListDto>();

			CreateMap<NewsletterSubscription, NewsletterSubscriptionDto>()
				.ForMember(dest => dest.CustomerFullName, opt =>
					opt.MapFrom(src =>
						src.Customer != null ? $"{src.Customer.FirstName} {src.Customer.LastName}" : null));

			CreateMap<NewsletterSubscriptionCreateDto, NewsletterSubscription>();
			CreateMap<NewsletterSubscriptionUpdateDto, NewsletterSubscription>();
		}
	}

}
