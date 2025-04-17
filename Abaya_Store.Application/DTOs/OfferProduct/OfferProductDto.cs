using Abaya_Store.Application.DTOs.Offer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.OfferProduct
{
	public class OfferProductDto
	{
		public int Id { get; set; }
		public int OfferId { get; set; }
		public int ProductId { get; set; }

		public OfferDto Offer { get; set; } // تفاصيل العرض
		public ProductDto Product { get; set; } // تفاصيل المنتج
	}
	public class OfferProductListDto
	{
		public int Id { get; set; }
		public int OfferId { get; set; }
		public int ProductId { get; set; }

		public string ProductName { get; set; }  // للحصول على اسم المنتج المرتبط بالعروض
	}
	public class OfferProductUpdateDto
	{
		public int Id { get; set; }
		public int OfferId { get; set; }
		public int ProductId { get; set; }
	}
	public class OfferProductCreateDto
	{
		public int OfferId { get; set; }
		public int ProductId { get; set; }
	}


}
