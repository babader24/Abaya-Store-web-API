namespace Abaya_Store.Application.DTOs.ProductReview
{
	public interface IProductReviewDto
	{
		public int ProductId { get; set; }
		public int CustomerId { get; set; }
		public int Rating { get; set; }
		public string Comment { get; set; }
	}
}
