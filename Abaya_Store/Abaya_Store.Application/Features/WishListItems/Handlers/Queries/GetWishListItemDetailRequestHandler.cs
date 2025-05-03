using Abaya_Store.Application.DTOs.WishListItem;
using Abaya_Store.Application.Features.WishListItems.Requests.Queries;
using Abaya_Store.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;

namespace Abaya_Store.Application.Features.WishListItems.Handlers.Queries
{
	public class GetWishListItemDetailRequestHandler : IRequestHandler<GetWishListItemDetailRequest, WishListItemDto>
	{
		private readonly IWishListItemRepository _wishListItemRepository;
		private readonly IMapper _mapper;

		public GetWishListItemDetailRequestHandler(IWishListItemRepository wishListItemRepository, IMapper mapper)
		{
			_wishListItemRepository = wishListItemRepository;
			_mapper = mapper;
		}

		public async Task<WishListItemDto> Handle(GetWishListItemDetailRequest request, CancellationToken cancellationToken)
		{
			var item = await _wishListItemRepository.GetByIdAsync(request.Id);
			return _mapper.Map<WishListItemDto>(item);
		}
	}
}
