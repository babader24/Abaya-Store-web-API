namespace AbayaStore.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Image { get; set; }
		public decimal UnitPrice { get; set; }
		public string Description { get; set; }
		public int CategoryId { get; set; }
		public string Size { get; set; }
		public int QuantityAvailable { get; set; }

		public virtual Offer? Offer { get; set; }
		public virtual Category Category { get; set; }
		public virtual ICollection<ProductReview> ProductReviews { get; set; } = new List<ProductReview>();

	}
}
