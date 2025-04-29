using Abaya_Store.Application.DTOs.Cart.Validator;
using Abaya_Store.Application.Features.Carts.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Carts.Handlers.Commands
{
	public class CreateCartCommandHandler : IRequestHandler<CreateCartCommand, int>
	{
		private readonly ICartRepository _cartRepository;
		private readonly IMapper _mapper;

		public CreateCartCommandHandler(ICartRepository cartRepository, IMapper mapper)
		{
			_cartRepository = cartRepository;
			_mapper = mapper;
		}
		public async Task<int> Handle(CreateCartCommand request, CancellationToken cancellationToken)
		{
			var validator = new CartCreateDtoValidator ();
			var validatorResult = validator.Validate(request.CartDto);

			if (validatorResult.IsValid == false)
				throw new Exception();
			var cart = _mapper.Map<Cart>(request.CartDto);

			cart = await _cartRepository.AddAsync(cart);

			return cart.Id;
		}
	}
}
