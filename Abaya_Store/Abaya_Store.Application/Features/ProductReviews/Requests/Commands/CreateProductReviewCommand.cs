using Abaya_Store.Application.DTOs.ProductReview;
using Abaya_Store.Application.Responses;
using MediatR;

namespace Abaya_Store.Application.Features.ProductReviews.Requests.Commands
{
	public class CreateProductReviewCommand : IRequest<BaseCommandRespons>
	{
		public ProductReviewCreateDto CreateDto { get; set; }
	}
}
