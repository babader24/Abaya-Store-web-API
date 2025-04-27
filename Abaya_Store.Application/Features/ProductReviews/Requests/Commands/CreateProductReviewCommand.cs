using Abaya_Store.Application.DTOs.ProductReview;
using MediatR;

namespace Abaya_Store.Application.Features.ProductReviews.Requests.Commands
{
	public class CreateProductReviewCommand : IRequest<int>
	{
		public ProductReviewCreateDto CreateDto { get; set; }
	}
}
