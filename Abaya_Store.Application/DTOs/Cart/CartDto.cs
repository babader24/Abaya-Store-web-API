using Abaya_Store.Application.DTOs.CartItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.Cart
{
    class CartDto
    {
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public string CustomerName { get; set; }
		public List<CartItemDto> Items { get; set; }
	}
	public class CartCreateDto
	{
		public int CustomerId { get; set; }
		public List<CartItemCreateDto> Items { get; set; } = new();
	}
	public class CartListDto
	{
		public int Id { get; set; }
		public string CustomerName { get; set; }
		public int ItemCount { get; set; }
	}
}
