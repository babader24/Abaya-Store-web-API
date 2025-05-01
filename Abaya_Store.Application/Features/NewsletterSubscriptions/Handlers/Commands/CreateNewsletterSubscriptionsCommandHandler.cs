using Abaya_Store.Application.DTOs.NewsletterSubscription.Validator;
using Abaya_Store.Application.Features.NewsletterSubscriptions.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using Abaya_Store.Application.Responses;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.NewsletterSubscriptions.Handlers.Commands
{
	public class CreateNewsletterSubscriptionsCommandHandler : IRequestHandler<CreateNewsletterSubscriptionsCommand, BaseCommandRespons>
	{
		private readonly INewsletterSubscriptionRepository _subscriptionRepository;
		private readonly IMapper _mapper;

		public CreateNewsletterSubscriptionsCommandHandler(INewsletterSubscriptionRepository subscriptionRepository, IMapper mapper)
		{
			_subscriptionRepository = subscriptionRepository;
			_mapper = mapper;
		}
		public async Task<BaseCommandRespons> Handle(CreateNewsletterSubscriptionsCommand request, CancellationToken cancellationToken)
		{
			var response = new BaseCommandRespons();
			var validator = new NewsletterSubscriptionCreateDtoValidator();
			var validatorResult = validator.Validate(request.newsletterSubscription);

			if (validatorResult.IsValid == false)
				response.Failure(validatorResult.Errors.Select(e => e.ErrorMessage).ToList());

			var newssubscription = _mapper.Map<NewsletterSubscription>(request.newsletterSubscription);

			newssubscription = await _subscriptionRepository.AddAsync(newssubscription);

			response.Success(newssubscription.Id);
			return response;
		}
	}
}
