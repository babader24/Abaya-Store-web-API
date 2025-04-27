using Abaya_Store.Application.DTOs.CartItem;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.CartItems.Requests.Commands
{
    class CreateCartItemCommand : IRequest<int>
    {
		public CartItemDto CartItemDto { get; set; }
	}
	class DeleteCartItemCommand : IRequest
	{
		public int Id { get; set; }
	}
}
