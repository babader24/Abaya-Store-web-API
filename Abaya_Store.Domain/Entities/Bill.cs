namespace AbayaStore.Models
{
	public class Bill
	{
		public int Id { get; set; }
		public string BillNumber { get; set; }
		public int CustomerId { get; set; }
		public DateTime BillDate { get; set; } = DateTime.Now;
		public decimal Total { get; set; }
		public string Notes { get; set; }
		public byte PaymentStatus { get; set; } 

		public virtual ShippingInfo ShippingInfo { get; set; }
		public virtual Customer Customer { get; set; }
	}
}
