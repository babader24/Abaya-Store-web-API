using Abaya_Store.Application.DTOs.ProductReview;
using Abaya_Store.Application.Features.ProductReviews.Requests.Queries;
using Abaya_Store.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;

namespace Abaya_Store.Application.Features.ProductReviews.Handlers.Queries
{
	public class GetProductReviewDetailRequestHandler : IRequestHandler<GetProductReviewDetailRequest, ProductReviewDto>
	{
		private readonly IProductReviewRepository _productReviewRepository;
		private readonly IMapper _mapper;

		public GetProductReviewDetailRequestHandler(IProductReviewRepository productReviewRepository, IMapper mapper)
		{
			_productReviewRepository = productReviewRepository;
			_mapper = mapper;
		}

		public async Task<ProductReviewDto> Handle(GetProductReviewDetailRequest request, CancellationToken cancellationToken)
		{
			var review = await _productReviewRepository.GetByIdAsync(request.Id);
			return _mapper.Map<ProductReviewDto>(review);
		}
	}
}
