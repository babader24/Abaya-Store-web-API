using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.ProductReview
{
	public class ProductReviewDto
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public int CustomerId { get; set; }
		public int Rating { get; set; } // 1-5
		public string Comment { get; set; }
		public DateTime Date { get; set; }
	}
	public class ProductReviewCreateDto : IProductReviewDto
	{
		public int ProductId { get; set; }
		public int CustomerId { get; set; }
		public int Rating { get; set; } // 1-5
		public string Comment { get; set; }
	}

	public class ProductReviewUpdateDto : IProductReviewDto
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public int CustomerId { get; set; }
		public int Rating { get; set; } // 1-5
		public string Comment { get; set; }
	}

	public class ProductReviewListDto
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public int Rating { get; set; } // 1-5
		public string Comment { get; set; }
	}
}
