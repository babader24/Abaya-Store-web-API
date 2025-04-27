using MediatR;

namespace Abaya_Store.Application.Features.WishLists.Requests.Commands
{
	public class DeleteWishListCommand : IRequest<Unit>
	{
		public int Id { get; set; }
	}
}
