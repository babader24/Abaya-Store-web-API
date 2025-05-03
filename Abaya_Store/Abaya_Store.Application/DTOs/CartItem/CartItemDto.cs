using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.CartItem
{
	public class CartItemDto
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public int Quantity { get; set; }
		public DateTime DateAdded { get; set; }
	}
	public class CartItemListDto
	{
		public int Id { get; set; }
		public string ProductName { get; set; }
		public int Quantity { get; set; }
	}
	public class CartItemCreateDto : ICartItemDto
	{
		public int ProductId { get; set; }
		public int Quantity { get; set; }
	}
	public class CartItemUpdateDto : ICartItemDto
	{
		public int Id { get; set; }
		public int Quantity { get; set; }
	}
}
