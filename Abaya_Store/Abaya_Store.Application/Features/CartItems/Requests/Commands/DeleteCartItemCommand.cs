using MediatR;

namespace Abaya_Store.Application.Features.CartItems.Requests.Commands
{
	class DeleteCartItemCommand : IRequest
	{
		public int Id { get; set; }
	}
}
