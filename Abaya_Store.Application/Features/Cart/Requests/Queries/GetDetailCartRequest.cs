using Abaya_Store.Application.DTOs.Cart;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Cart.Requests.Queries
{
    public class GetDetailCartRequest : IRequest<CartDto>
    {
		public int Id { get; set; }
	}
}
