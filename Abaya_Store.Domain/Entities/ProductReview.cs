namespace Abaya_Store.Domain.Entities
{
	public class ProductReview
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public int CustomerId { get; set; }
		public int Rating { get; set; } // 1-5
		public string Comment { get; set; }
		public DateTime Date { get; set; } = DateTime.Now;

		public virtual Product Product { get; set; }
	}
}
