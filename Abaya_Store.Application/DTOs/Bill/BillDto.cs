using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.Bill
{
    public class BillDto
    {
		public int Id { get; set; }
		public string BillNumber { get; set; }
		public int CustomerId { get; set; }
		public DateTime BillDate { get; set; }
		public decimal Total { get; set; }
		public string Notes { get; set; }
		public byte PaymentStatus { get; set; }

		// معلومات إضافية للعرض
		public string? CustomerName { get; set; }
		public string? ShippingAddress { get; set; }
	}
	public class CreateBillDto
	{
		public string BillNumber { get; set; }
		public int CustomerId { get; set; }
		public decimal Total { get; set; }
		public string Notes { get; set; }
		public byte PaymentStatus { get; set; }

		// ممكن ترسل بيانات الشحن لو حابب
		// public ShippingInfoDto ShippingInfo { get; set; }
	}
	public class UpdateBillDto
	{
		public string BillNumber { get; set; }
		public int CustomerId { get; set; }
		public DateTime BillDate { get; set; }
		public decimal Total { get; set; }
		public string Notes { get; set; }
		public byte PaymentStatus { get; set; }
	}
}
