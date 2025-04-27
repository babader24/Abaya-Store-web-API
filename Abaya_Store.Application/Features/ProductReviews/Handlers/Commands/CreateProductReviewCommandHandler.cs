using Abaya_Store.Application.Features.ProductReviews.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using MediatR;

namespace Abaya_Store.Application.Features.ProductReviews.Handlers.Commands
{
	public class CreateProductReviewCommandHandler : IRequestHandler<CreateProductReviewCommand, int>
	{
		private readonly IProductReviewRepository _productReviewRepository;
		private readonly IMapper _mapper;

		public CreateProductReviewCommandHandler(IProductReviewRepository productReviewRepository, IMapper mapper)
		{
			_productReviewRepository = productReviewRepository;
			_mapper = mapper;
		}

		public async Task<int> Handle(CreateProductReviewCommand request, CancellationToken cancellationToken)
		{
			var review = _mapper.Map<ProductReview>(request.CreateDto);

			review = await _productReviewRepository.AddAsync(review);

			return review.Id;
		}
	}
}
