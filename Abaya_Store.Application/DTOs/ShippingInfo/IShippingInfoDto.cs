namespace Abaya_Store.Application.DTOs.ShippingInfo
{
	public interface IShippingInfoDto
	{
		public string City { get; set; }
		public string Address { get; set; }
		public string PostalCode { get; set; }
		public byte DeliveryStatus { get; set; }
	}

}
