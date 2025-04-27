using Abaya_Store.Application.DTOs.WishList;
using Abaya_Store.Application.Features.WishLists.Requests.Queries;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.WishLists.Handlers.Queries
{
	public class GetWishListsRequestHandler : IRequestHandler<GetWishListsRequest, List<WishListListDto>>
	{
		private readonly IWishListRepository _wishListRepository;
		private readonly IMapper _mapper;

		public GetWishListsRequestHandler(IWishListRepository wishListRepository, IMapper mapper)
		{
			_wishListRepository = wishListRepository;
			_mapper = mapper;
		}

		public async Task<List<WishListListDto>> Handle(GetWishListsRequest request, CancellationToken cancellationToken)
		{
			var wishLists = await _wishListRepository.GetAllAsync();
			return _mapper.Map<List<WishListListDto>>(wishLists);
		}
	}

}
