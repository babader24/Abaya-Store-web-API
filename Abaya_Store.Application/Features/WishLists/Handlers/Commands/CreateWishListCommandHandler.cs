using Abaya_Store.Application.DTOs.WishList.Validator;
using Abaya_Store.Application.Features.WishLists.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using Abaya_Store.Application.Responses;
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
	public class CreateWishListCommandHandler : IRequestHandler<CreateWishListCommand, BaseCommandRespons>
	{
		private readonly IWishListRepository _wishListRepository;
		private readonly IMapper _mapper;

		public CreateWishListCommandHandler(IWishListRepository wishListRepository, IMapper mapper)
		{
			_wishListRepository = wishListRepository;
			_mapper = mapper;
		}

		public async Task<BaseCommandRespons> Handle(CreateWishListCommand request, CancellationToken cancellationToken)
		{
			var response = new BaseCommandRespons();
			var validator = new WhshListCreateDtoValidator();
			var validationResult = validator.Validate(request.CreateDto);

			if (validationResult.IsValid == false)
				response.Failure(validationResult.Errors.Select(e => e.ErrorMessage).ToList());

			var wishList = _mapper.Map<WishList>(request.CreateDto);
			wishList = await _wishListRepository.AddAsync(wishList);

			response.Success(wishList.Id);
			return response;
		}
	}
}
