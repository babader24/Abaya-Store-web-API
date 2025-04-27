using Abaya_Store.Application.DTOs.NewsletterSubscription;
using Abaya_Store.Application.Features.NewsletterSubscriptions.Requests.Queries;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.NewsletterSubscriptions.Handlers.Queries
{
	public class GetNewsletterSubscriptionsListRequestHandler : IRequestHandler<GetNewsletterSubscriptionsListRequest, List<NewsletterSubscriptionListDto>>
	{
		private readonly INewsletterSubscriptionRepository _subscriptionRepository;
		private readonly IMapper _mapper;

		public GetNewsletterSubscriptionsListRequestHandler(INewsletterSubscriptionRepository subscriptionRepository , IMapper  mapper)
		{
			_subscriptionRepository = subscriptionRepository;
			_mapper = mapper;
		}
		public async Task<List<NewsletterSubscriptionListDto>> Handle(GetNewsletterSubscriptionsListRequest request, CancellationToken cancellationToken)
		{
			var newsSubscriptions = await _subscriptionRepository.GetAllAsync();

			return _mapper.Map<List<NewsletterSubscriptionListDto>>(newsSubscriptions);
		}
	}
}
