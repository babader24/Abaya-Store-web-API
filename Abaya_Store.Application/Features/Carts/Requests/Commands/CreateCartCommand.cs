using Abaya_Store.Application.DTOs.Cart;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Carts.Requests.Commands
{
    public class CreateCartCommand : IRequest<int>
    {
		public CartDto CartDto { get; set; }
	}
	public class UpdateCartCommand : IRequest<int>
	{
		public CartDto CartDto { get; set; }
	}
}
