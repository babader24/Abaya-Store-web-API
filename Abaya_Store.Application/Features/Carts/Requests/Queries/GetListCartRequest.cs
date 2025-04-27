using Abaya_Store.Application.DTOs.Cart;
using MediatR;

namespace Abaya_Store.Application.Features.Carts.Requests.Queries
{
	public class GetListCartRequest : IRequest<List<CartDto>>
	{
	}
}
