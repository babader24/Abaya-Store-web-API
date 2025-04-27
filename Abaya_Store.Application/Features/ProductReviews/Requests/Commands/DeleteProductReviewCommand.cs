using MediatR;

namespace Abaya_Store.Application.Features.ProductReviews.Requests.Commands
{
	public class DeleteProductReviewCommand : IRequest<Unit>
	{
		public int Id { get; set; }
	}
}
