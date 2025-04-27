using Abaya_Store.Application.DTOs.CartItem;
using Abaya_Store.Application.Features.CartItems.Requests.Queries;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.CartItems.Handlers.Queries
{
	public class GetCartItemsListRequestHandler : IRequestHandler<GetCartItemsListRequest, List<CartItemDto>>
	{
		private readonly ICartItemRepository _cartItemRepository;
		private readonly IMapper _mapper;

		public GetCartItemsListRequestHandler(ICartItemRepository cartItemRepository, IMapper mapper)
		{
			_cartItemRepository = cartItemRepository;
			_mapper = mapper;
		}
		public async Task<List<CartItemDto>> Handle(GetCartItemsListRequest request, CancellationToken cancellationToken)
		{
			var cartItemsList = await _cartItemRepository.GetAllAsync();

			return _mapper.Map<List<CartItemDto>>(cartItemsList);
		}
	}
}
