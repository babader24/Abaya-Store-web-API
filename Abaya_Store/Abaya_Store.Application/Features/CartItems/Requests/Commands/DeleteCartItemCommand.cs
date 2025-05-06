using MediatR;

namespace Abaya_Store.Application.Features.CartItems.Requests.Commands
{
	public class DeleteCartItemCommand : IRequest
	{
		public int Id { get; set; }
	}
}
