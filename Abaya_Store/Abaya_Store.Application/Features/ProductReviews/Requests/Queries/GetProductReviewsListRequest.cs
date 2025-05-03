using Abaya_Store.Application.DTOs.ProductReview;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.ProductReviews.Requests.Queries
{
	public class GetProductReviewsListRequest : IRequest<List<ProductReviewListDto>>
	{
	}
}
