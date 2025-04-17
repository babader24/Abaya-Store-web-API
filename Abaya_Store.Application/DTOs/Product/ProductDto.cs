using Abaya_Store.Application.DTOs.Category;
using Abaya_Store.Application.DTOs.Offer;
using Abaya_Store.Application.DTOs.ProductReview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.Product
{
	public class ProductDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Image { get; set; }
		public decimal UnitPrice { get; set; }
		public string Description { get; set; }
		public string Size { get; set; }
		public int QuantityAvailable { get; set; }
		public CategoryDto Category { get; set; }  // تفاصيل الفئة
		public OfferDto? Offer { get; set; }  // تفاصيل العرض إذا كان موجودًا
		public ICollection<ProductReviewDto> ProductReviews { get; set; } = new List<ProductReviewDto>();
	}
	public class ProductListDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal UnitPrice { get; set; }
		public int QuantityAvailable { get; set; }
		public string Size { get; set; }
	}
	public class ProductCreateDto
	{
		public string Name { get; set; }
		public string Image { get; set; }
		public decimal UnitPrice { get; set; }
		public string Description { get; set; }
		public int CategoryId { get; set; }
		public string Size { get; set; }
		public int QuantityAvailable { get; set; }
		public int? OfferId { get; set; }  // يمكن إضافة عرض أو لا
	}

	public class ProductUpdateDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Image { get; set; }
		public decimal UnitPrice { get; set; }
		public string Description { get; set; }
		public int CategoryId { get; set; }
		public string Size { get; set; }
		public int QuantityAvailable { get; set; }
		public int? OfferId { get; set; }  // يمكن تعديل العرض أو لا
	}

}
