using Abaya_Store.Application.Features.NewsletterSubscriptions.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.NewsletterSubscriptions.Handlers.Commands
{
	public class DeleteNewsletterSubscriptionsCommandHandler : IRequestHandler<DeleteNewsletterSubscriptionsCommand>
	{
		private readonly INewsletterSubscriptionRepository _subscriptionRepository;
		private readonly IMapper _mapper;

		public DeleteNewsletterSubscriptionsCommandHandler(INewsletterSubscriptionRepository subscriptionRepository, IMapper mapper)
		{
			_subscriptionRepository = subscriptionRepository;
			_mapper = mapper;
		}
		public async Task<Unit> Handle(DeleteNewsletterSubscriptionsCommand request, CancellationToken cancellationToken)
		{
			var subscription = await _subscriptionRepository.GetByIdAsync(request.Id);

			await _subscriptionRepository.DeleteAsync(subscription);

			return Unit.Value;
		}
	}
}
