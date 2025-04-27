using Abaya_Store.Application.DTOs.ProductReview;
using Abaya_Store.Application.Features.ProductReviews.Requests.Queries;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.ProductReviews.Handlers.Queries
{
	public class GetProductReviewsListRequestHandler : IRequestHandler<GetProductReviewsListRequest, List<ProductReviewListDto>>
	{
		private readonly IProductReviewRepository _productReviewRepository;
		private readonly IMapper _mapper;

		public GetProductReviewsListRequestHandler(IProductReviewRepository productReviewRepository, IMapper mapper)
		{
			_productReviewRepository = productReviewRepository;
			_mapper = mapper;
		}

		public async Task<List<ProductReviewListDto>> Handle(GetProductReviewsListRequest request, CancellationToken cancellationToken)
		{
			var reviews = await _productReviewRepository.GetAllAsync();
			return _mapper.Map<List<ProductReviewListDto>>(reviews);
		}
	}
}
