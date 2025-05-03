namespace Abaya_Store.Application.DTOs.Product
{
	public interface IProductDto
	{
		public string Name { get; set; }
		public string Image { get; set; }
		public decimal UnitPrice { get; set; }
		public string Description { get; set; }
		public int CategoryId { get; set; }
		public string Size { get; set; }
		public int QuantityAvailable { get; set; }
		public int? OfferId { get; set; }
	}

}
