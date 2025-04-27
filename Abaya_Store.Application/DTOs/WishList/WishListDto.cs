using Abaya_Store.Application.DTOs.WishListItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.WishList
{
	public class WishListDto
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }

		public List<WishListItemDto> Items { get; set; }
	}
	public class WishListCreateDto
	{
		public int CustomerId { get; set; }
	}

	public class WishListListDto
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public int TotalItems => Items?.Count ?? 0;

		public List<WishListItemListfDto> Items { get; set; }
	}

}
