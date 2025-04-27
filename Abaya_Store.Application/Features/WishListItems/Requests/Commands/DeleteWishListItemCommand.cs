using MediatR;

namespace Abaya_Store.Application.Features.WishListItems.Requests.Commands
{
	public class DeleteWishListItemCommand : IRequest<Unit>
	{
		public int Id { get; set; }
	}
}
