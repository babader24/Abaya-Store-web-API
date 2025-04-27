using Abaya_Store.Application.DTOs.ProductReview;
using MediatR;

namespace Abaya_Store.Application.Features.ProductReviews.Requests.Queries
{
	public class GetProductReviewDetailRequest : IRequest<ProductReviewDto>
	{
		public int Id { get; set; }
	}
}
