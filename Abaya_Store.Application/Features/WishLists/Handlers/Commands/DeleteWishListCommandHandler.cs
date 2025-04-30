using Abaya_Store.Application.Exceptions;
using Abaya_Store.Application.Features.WishLists.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace Abaya_Store.Application.Features.WishLists.Handlers.Commands
{
	public class DeleteWishListCommandHandler : IRequestHandler<DeleteWishListCommand>
	{
		private readonly IWishListRepository _wishListRepository;
		private readonly IMapper _mapper;

		public DeleteWishListCommandHandler(IWishListRepository wishListRepository, IMapper mapper)
		{
			_wishListRepository = wishListRepository;
			_mapper = mapper;
		}

		public async Task<Unit> Handle(DeleteWishListCommand request, CancellationToken cancellationToken)
		{
			var wishList = await _wishListRepository.GetByIdAsync(request.Id);

			if (wishList == null)
				throw new NotFoundException(nameof(wishList), request.Id);

			await _wishListRepository.DeleteAsync(wishList);
			return Unit.Value;
		}
	}
}
