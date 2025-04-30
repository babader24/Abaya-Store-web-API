using Abaya_Store.Application.Exceptions;
using Abaya_Store.Application.Features.CartItems.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.CartItems.Handlers.Commands
{
	class DeleteCartItemCommandHandler : IRequestHandler<DeleteCartItemCommand>
	{
		private readonly ICartItemRepository _cartItemRepository;
	

		public DeleteCartItemCommandHandler(ICartItemRepository cartItemRepository)
		{
			_cartItemRepository = cartItemRepository;			
		}
		public async Task<Unit> Handle(DeleteCartItemCommand request, CancellationToken cancellationToken)
		{
			var cartItem = await _cartItemRepository.GetByIdAsync(request.Id);
			if (cartItem == null)
				throw new NotFoundException(nameof(cartItem), request.Id);

			await _cartItemRepository.DeleteAsync(cartItem);

			return Unit.Value;
		}
	}
}
