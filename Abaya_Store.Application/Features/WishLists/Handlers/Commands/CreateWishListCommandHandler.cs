using Abaya_Store.Application.Features.WishLists.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.WishLists.Handlers.Commands
{
	public class CreateWishListCommandHandler : IRequestHandler<CreateWishListCommand, int>
	{
		private readonly IWishListRepository _wishListRepository;
		private readonly IMapper _mapper;

		public CreateWishListCommandHandler(IWishListRepository wishListRepository, IMapper mapper)
		{
			_wishListRepository = wishListRepository;
			_mapper = mapper;
		}

		public async Task<int> Handle(CreateWishListCommand request, CancellationToken cancellationToken)
		{
			var wishList = _mapper.Map<WishList>(request.CreateDto);
			wishList = await _wishListRepository.AddAsync(wishList);
			return wishList.Id;
		}
	}
}
