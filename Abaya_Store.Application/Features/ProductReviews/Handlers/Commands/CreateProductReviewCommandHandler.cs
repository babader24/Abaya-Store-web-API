using Abaya_Store.Application.DTOs.ProductReview.Validator;
using Abaya_Store.Application.Features.ProductReviews.Requests.Commands;
using Abaya_Store.Application.Contracts.Persistence;
using Abaya_Store.Application.Responses;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using MediatR;

namespace Abaya_Store.Application.Features.ProductReviews.Handlers.Commands
{
	public class CreateProductReviewCommandHandler : IRequestHandler<CreateProductReviewCommand, BaseCommandRespons>
	{
		private readonly IProductReviewRepository _productReviewRepository;
		private readonly IMapper _mapper;

		public CreateProductReviewCommandHandler(IProductReviewRepository productReviewRepository, IMapper mapper)
		{
			_productReviewRepository = productReviewRepository;
			_mapper = mapper;
		}

		public async Task<BaseCommandRespons> Handle(CreateProductReviewCommand request, CancellationToken cancellationToken)
		{
			var response = new BaseCommandRespons();
			var createValidator = new ProductReviewCreateDtoValidator();
			var createResult = createValidator.Validate(request.CreateDto);

			if (createResult.IsValid == false)
				response.Failure(createResult.Errors.Select(e => e.ErrorMessage).ToList());

			var review = _mapper.Map<ProductReview>(request.CreateDto);

			review = await _productReviewRepository.AddAsync(review);

			response.Success(review.Id);
			return response;
		}
	}
}
