using Abaya_Store.Application.DTOs.WishList;
using Abaya_Store.Application.Features.WishLists.Requests.Queries;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace Abaya_Store.Application.Features.WishLists.Handlers.Queries
{
	public class GetWishListDetailRequestHandler : IRequestHandler<GetWishListDetailRequest, WishListDto>
	{
		private readonly IWishListRepository _wishListRepository;
		private readonly IMapper _mapper;

		public GetWishListDetailRequestHandler(IWishListRepository wishListRepository, IMapper mapper)
		{
			_wishListRepository = wishListRepository;
			_mapper = mapper;
		}

		public async Task<WishListDto> Handle(GetWishListDetailRequest request, CancellationToken cancellationToken)
		{
			var wishList = await _wishListRepository.GetByIdIncludeAsync(request.Id);
			return _mapper.Map<WishListDto>(wishList);
		}
	}

}
