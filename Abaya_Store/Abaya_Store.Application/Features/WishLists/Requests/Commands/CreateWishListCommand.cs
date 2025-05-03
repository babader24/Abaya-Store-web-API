using Abaya_Store.Application.DTOs.WishList;
using Abaya_Store.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.WishLists.Requests.Commands
{
	public class CreateWishListCommand : IRequest<BaseCommandRespons>
	{
		public WishListCreateDto CreateDto { get; set; }
	}
}
