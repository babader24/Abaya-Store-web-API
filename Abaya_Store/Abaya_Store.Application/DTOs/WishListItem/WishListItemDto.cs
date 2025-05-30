﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.WishListItem
{
	public class WishListItemDto
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public string ProductImage { get; set; }
		public decimal ProductPrice { get; set; }
		public DateTime DateAdded { get; set; }
	}
	public class WishListItemCreateDto : IWishListItemDto
	{
		public int ProductId { get; set; }
	}
	public class WishListItemUpdateDto : IWishListItemDto
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
	}
	public class WishListItemListfDto
	{
		public int Id { get; set; }
		public string ProductName { get; set; }
	}

}
