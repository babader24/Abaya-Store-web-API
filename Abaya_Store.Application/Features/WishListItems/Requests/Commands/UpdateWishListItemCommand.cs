using Abaya_Store.Application.DTOs.WishListItem;
using MediatR;

namespace Abaya_Store.Application.Features.WishListItems.Requests.Commands
{
	public class UpdateWishListItemCommand : IRequest<Unit>
	{
		public WishListItemUpdateDto UpdateDto { get; set; }
	}
}
