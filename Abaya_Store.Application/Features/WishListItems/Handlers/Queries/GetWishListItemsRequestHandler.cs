using Abaya_Store.Application.DTOs.WishListItem;
using Abaya_Store.Application.Features.WishListItems.Requests.Queries;
using Abaya_Store.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.WishListItems.Handlers.Queries
{
	public class GetWishListItemsRequestHandler : IRequestHandler<GetWishListItemsRequest, List<WishListItemListfDto>>
	{
		private readonly IWishListItemRepository _wishListItemRepository;
		private readonly IMapper _mapper;

		public GetWishListItemsRequestHandler(IWishListItemRepository wishListItemRepository, IMapper mapper)
		{
			_wishListItemRepository = wishListItemRepository;
			_mapper = mapper;
		}

		public async Task<List<WishListItemListfDto>> Handle(GetWishListItemsRequest request, CancellationToken cancellationToken)
		{
			var items = await _wishListItemRepository.GetAllIncludingAsync();
			return _mapper.Map<List<WishListItemListfDto>>(items);
		}
	}
}
