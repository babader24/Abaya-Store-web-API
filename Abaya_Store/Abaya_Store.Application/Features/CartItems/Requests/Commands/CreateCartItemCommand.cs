using Abaya_Store.Application.DTOs.CartItem;
using Abaya_Store.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.CartItems.Requests.Commands
{
    public class CreateCartItemCommand : IRequest<BaseCommandRespons>
    {
		public  CartItemCreateDto createDto { get; set; }
	}
}
