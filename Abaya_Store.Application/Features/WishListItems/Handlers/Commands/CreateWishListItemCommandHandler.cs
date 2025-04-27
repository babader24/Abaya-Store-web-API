using Abaya_Store.Application.Features.WishListItems.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.WishListItems.Handlers.Commands
{
	public class CreateWishListItemCommandHandler : IRequestHandler<CreateWishListItemCommand, int>
	{
		private readonly IWishListItemRepository _wishListItemRepository;
		private readonly IMapper _mapper;

		public CreateWishListItemCommandHandler(IWishListItemRepository wishListItemRepository, IMapper mapper)
		{
			_wishListItemRepository = wishListItemRepository;
			_mapper = mapper;
		}

		public async Task<int> Handle(CreateWishListItemCommand request, CancellationToken cancellationToken)
		{
			var wishListItem = _mapper.Map<WishListItem>(request.CreateDto);
		

			wishListItem = await _wishListItemRepository.AddAsync(wishListItem);
			return wishListItem.Id;
		}
	}
}
