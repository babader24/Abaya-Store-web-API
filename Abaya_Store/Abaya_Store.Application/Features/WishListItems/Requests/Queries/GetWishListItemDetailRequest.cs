using Abaya_Store.Application.DTOs.WishListItem;
using MediatR;

namespace Abaya_Store.Application.Features.WishListItems.Requests.Queries
{
	public class GetWishListItemDetailRequest : IRequest<WishListItemDto>
	{
		public int Id { get; set; }
	}
}
