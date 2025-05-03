using Abaya_Store.Application.DTOs.WishList;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.WishLists.Requests.Queries
{
	public class GetWishListsRequest : IRequest<List<WishListListDto>>
	{
	}
}
