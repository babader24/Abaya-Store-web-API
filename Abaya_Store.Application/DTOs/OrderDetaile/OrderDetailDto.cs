using Abaya_Store.Application.DTOs.Bill;
using Abaya_Store.Application.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.OrderDetaile
{
	public class OrderDetailDto
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public int Quantity { get; set; }
		public decimal UnitPrice { get; set; }
		public decimal Amount { get; set; }
		public int BillId { get; set; }

		public ProductDto Product { get; set; } // تفاصيل المنتج المرتبط بالطلب
		public BillDto Bill { get; set; } // تفاصيل الفاتورة المرتبطة بالطلب
	}
	public class OrderDetailCreateDto : IOrderDetailDto
	{
		public int ProductId { get; set; }
		public int Quantity { get; set; }
		public decimal UnitPrice { get; set; }
		public decimal Amount { get; set; }
		public int BillId { get; set; }
	}

	public class OrderDetailUpdateDto : IOrderDetailDto
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public int Quantity { get; set; }
		public decimal UnitPrice { get; set; }
		public decimal Amount { get; set; }
		public int BillId { get; set; }
	}

	public class OrderDetailListDto
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public int Quantity { get; set; }
		public decimal UnitPrice { get; set; }
		public decimal Amount { get; set; }
		public int BillId { get; set; }

		public string ProductName { get; set; }  // للحصول على اسم المنتج المرتبط بتفاصيل الطلب
	}
}
