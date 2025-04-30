using Abaya_Store.Application.Exceptions;
using Abaya_Store.Application.Features.WishListItems.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace Abaya_Store.Application.Features.WishListItems.Handlers.Commands
{
	public class DeleteWishListItemCommandHandler : IRequestHandler<DeleteWishListItemCommand>
	{
		private readonly IWishListItemRepository _wishListItemRepository;
		private readonly IMapper _mapper;

		public DeleteWishListItemCommandHandler(IWishListItemRepository wishListItemRepository, IMapper mapper)
		{
			_wishListItemRepository = wishListItemRepository;
			_mapper = mapper;
		}

		public async Task<Unit> Handle(DeleteWishListItemCommand request, CancellationToken cancellationToken)
		{
			var item = await _wishListItemRepository.GetByIdAsync(request.Id);

			if (item == null)
				throw new NotFoundException(nameof(item), request.Id);

			await _wishListItemRepository.DeleteAsync(item);
			return Unit.Value;
		}
	}
}
