using Abaya_Store.Application.DTOs.CartItem.Validator;
using Abaya_Store.Application.Features.CartItems.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.CartItems.Handlers.Commands
{
	class CreateCartItemCommandHandler : IRequestHandler<CreateCartItemCommand, int>
	{
		private readonly ICartItemRepository _cartItemRepository;
		private readonly IMapper _mapper;

		public CreateCartItemCommandHandler(ICartItemRepository cartItemRepository, IMapper mapper)
		{
			_cartItemRepository = cartItemRepository;
			_mapper = mapper;
		}
		public async Task<int> Handle(CreateCartItemCommand request, CancellationToken cancellationToken)
		{
			var validator = new CartItemCreateDtoValidator();
			var validatorResult = validator.Validate(request.createDto);

			if (!validatorResult.IsValid)
				throw new Exception();

			var cartItem = _mapper.Map<CartItem>(request.createDto);

			cartItem = await _cartItemRepository.AddAsync(cartItem);

			return cartItem.Id;
		}
	}
}
