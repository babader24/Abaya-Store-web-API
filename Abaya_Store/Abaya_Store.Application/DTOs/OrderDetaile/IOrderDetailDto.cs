namespace Abaya_Store.Application.DTOs.OrderDetaile
{
	public interface IOrderDetailDto
	{
		public int ProductId { get; set; }
		public int Quantity { get; set; }
		public decimal UnitPrice { get; set; }
		public decimal Amount { get; set; }
		public int BillId { get; set; }
	}
}
