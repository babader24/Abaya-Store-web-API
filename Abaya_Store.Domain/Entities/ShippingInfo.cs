namespace AbayaStore.Models
{
	public class ShippingInfo
	{
		public int Id { get; set; }
		public int BillId { get; set; }
		public string City { get; set; }
		public string Address { get; set; }
		public string PostalCode { get; set; }
		public byte DeliveryStatus { get; set; } 

		public virtual Bill Bill { get; set; } 
	}
}
