using Abaya_Store.Application.DTOs.WishListItem.Validator;
using Abaya_Store.Application.Features.WishListItems.Requests.Commands;
using Abaya_Store.Application.Contracts.Persistence;
using Abaya_Store.Application.Responses;
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
	public class CreateWishListItemCommandHandler : IRequestHandler<CreateWishListItemCommand, BaseCommandRespons>
	{
		private readonly IWishListItemRepository _wishListItemRepository;
		private readonly IMapper _mapper;

		public CreateWishListItemCommandHandler(IWishListItemRepository wishListItemRepository, IMapper mapper)
		{
			_wishListItemRepository = wishListItemRepository;
			_mapper = mapper;
		}

		public async Task<BaseCommandRespons> Handle(CreateWishListItemCommand request, CancellationToken cancellationToken)
		{
			var response = new BaseCommandRespons();
			var createValidator = new WishListItemCreateDtoValidator();
			var createResult = createValidator.Validate(request.CreateDto);

			if (createResult.IsValid == false)
				response.Failure(createResult.Errors.Select(e => e.ErrorMessage).ToList());

			var wishListItem = _mapper.Map<WishListItem>(request.CreateDto);
		

			wishListItem = await _wishListItemRepository.AddAsync(wishListItem);

			response.Success(wishListItem.Id);
			return response;
		}
	}
}
