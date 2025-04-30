using Abaya_Store.Application.Exceptions;
using Abaya_Store.Application.Features.ProductReviews.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace Abaya_Store.Application.Features.ProductReviews.Handlers.Commands
{
	public class DeleteProductReviewCommandHandler : IRequestHandler<DeleteProductReviewCommand>
	{
		private readonly IProductReviewRepository _productReviewRepository;
		private readonly IMapper _mapper;

		public DeleteProductReviewCommandHandler(IProductReviewRepository productReviewRepository, IMapper mapper)
		{
			_productReviewRepository = productReviewRepository;
			_mapper = mapper;
		}

		public async Task<Unit> Handle(DeleteProductReviewCommand request, CancellationToken cancellationToken)
		{
			var review = await _productReviewRepository.GetByIdAsync(request.Id);

			if (review == null)
				throw new NotFoundException(nameof(review), request.Id);

			await _productReviewRepository.DeleteAsync(review);
			return Unit.Value;
		}
	}
}
