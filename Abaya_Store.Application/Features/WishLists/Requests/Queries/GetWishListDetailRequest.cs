using Abaya_Store.Application.DTOs.WishList;
using MediatR;

namespace Abaya_Store.Application.Features.WishLists.Requests.Queries
{
	public class GetWishListDetailRequest : IRequest<WishListDto>
	{
		public int Id { get; set; }
	}
}
