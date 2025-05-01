using Abaya_Store.Application.DTOs.WishListItem;
using Abaya_Store.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.WishListItems.Requests.Commands
{
	public class CreateWishListItemCommand : IRequest<BaseCommandRespons>
	{
		
		public WishListItemCreateDto CreateDto { get; set; }
	}
}
