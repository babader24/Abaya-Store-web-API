using Abaya_Store.Application.DTOs.ProductReview.Validator;
using Abaya_Store.Application.Features.ProductReviews.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.ProductReviews.Handlers.Commands
{
	public class UpdateProductReviewCommandHandler : IRequestHandler<UpdateProductReviewCommand>
	{
		private readonly IProductReviewRepository _productReviewRepository;
		private readonly IMapper _mapper;

		public UpdateProductReviewCommandHandler(IProductReviewRepository productReviewRepository, IMapper mapper)
		{
			_productReviewRepository = productReviewRepository;
			_mapper = mapper;
		}

		public async Task<Unit> Handle(UpdateProductReviewCommand request, CancellationToken cancellationToken)
		{
			var updateValidator = new ProductReviewUpdateDtoValidator();
			var updateResult = updateValidator.Validate(request.UpdateDto);

			if (!updateResult.IsValid)
				throw new Exception(string.Join("\n", updateResult.Errors));

			var review = await _productReviewRepository.GetByIdAsync(request.UpdateDto.Id);

			if (review != null)
			{
				_mapper.Map(request.UpdateDto, review);
				await _productReviewRepository.UpdateAsync(review);
			}

			return Unit.Value;
		}
	}
}
