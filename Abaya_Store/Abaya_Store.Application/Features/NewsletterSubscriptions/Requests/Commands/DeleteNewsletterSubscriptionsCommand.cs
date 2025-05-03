using MediatR;

namespace Abaya_Store.Application.Features.NewsletterSubscriptions.Requests.Commands
{
	public class DeleteNewsletterSubscriptionsCommand : IRequest<Unit>
	{
		public int Id { get; set; }
	}
}
