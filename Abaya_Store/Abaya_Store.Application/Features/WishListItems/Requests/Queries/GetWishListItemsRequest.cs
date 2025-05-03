using Abaya_Store.Application.DTOs.WishListItem;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.WishListItems.Requests.Queries
{
	public class GetWishListItemsRequest : IRequest<List<WishListItemListfDto>>
	{
		public int WishListId { get; set; }
	}
}
