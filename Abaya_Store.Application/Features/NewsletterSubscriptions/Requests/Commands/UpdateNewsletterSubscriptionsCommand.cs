using Abaya_Store.Application.DTOs.NewsletterSubscription;
using MediatR;

namespace Abaya_Store.Application.Features.NewsletterSubscriptions.Requests.Commands
{
	public class UpdateNewsletterSubscriptionsCommand : IRequest<Unit>
	{
		public NewsletterSubscriptionUpdateDto SubscriptionUpdateDto { get; set; }
	}
}
