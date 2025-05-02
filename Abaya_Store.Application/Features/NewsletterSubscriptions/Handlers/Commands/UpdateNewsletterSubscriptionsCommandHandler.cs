using Abaya_Store.Application.Features.NewsletterSubscriptions.Requests.Commands;
using Abaya_Store.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.NewsletterSubscriptions.Handlers.Commands
{
	public class UpdateNewsletterSubscriptionsCommandHandler : IRequestHandler<UpdateNewsletterSubscriptionsCommand>
	{
		private readonly INewsletterSubscriptionRepository _subscriptionRepository;
		private readonly IMapper _mapper;

		public UpdateNewsletterSubscriptionsCommandHandler(INewsletterSubscriptionRepository subscriptionRepository, IMapper mapper)
		{
			_subscriptionRepository = subscriptionRepository;
			_mapper = mapper;
		}
		public async Task<Unit> Handle(UpdateNewsletterSubscriptionsCommand request, CancellationToken cancellationToken)
		{
			var subscription = await _subscriptionRepository.GetByIdAsync(request.SubscriptionUpdateDto.Id);

			if(subscription != null)
			{
				_mapper.Map(request.SubscriptionUpdateDto, subscription);
				await _subscriptionRepository.UpdateAsync(subscription);
			}
			return Unit.Value;
		}
	}
}
