using Abaya_Store.Application.DTOs.NewsletterSubscription;
using Abaya_Store.Application.Features.NewsletterSubscriptions.Requests.Queries;
using Abaya_Store.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.NewsletterSubscriptions.Handlers.Queries
{
	public class GetDetailNewsletterSubscriptionRequestHandler : IRequestHandler<GetDetailNewsletterSubscriptionRequest, NewsletterSubscriptionDto>
	{
		private readonly INewsletterSubscriptionRepository _subscriptionRepository;
		private readonly IMapper _mapper;

		public GetDetailNewsletterSubscriptionRequestHandler(INewsletterSubscriptionRepository subscriptionRepository, IMapper mapper)
		{
			_subscriptionRepository = subscriptionRepository;
			_mapper = mapper;
		}
		public async Task<NewsletterSubscriptionDto> Handle(GetDetailNewsletterSubscriptionRequest request, CancellationToken cancellationToken)
		{
			var newsSubscription = await _subscriptionRepository.GetByIdIncludeAsync(request.Id);

			return _mapper.Map<NewsletterSubscriptionDto>(newsSubscription);
		}
	}
}
