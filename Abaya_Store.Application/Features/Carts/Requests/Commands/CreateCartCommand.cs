using Abaya_Store.Application.DTOs.Cart;
using Abaya_Store.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Carts.Requests.Commands
{
    public class CreateCartCommand : IRequest<BaseCommandRespons>
    {
		public CartCreateDto CartDto { get; set; }
	}
}
