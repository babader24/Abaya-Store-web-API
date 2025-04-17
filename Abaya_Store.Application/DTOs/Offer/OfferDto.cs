using Abaya_Store.Application.DTOs.OfferProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.Offer
{
	public class OfferDto
	{
		public int Id { get; set; }
		public decimal DiscountPercentage { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		public ICollection<OfferProductDto> Products { get; set; }
	}

	public class OfferListDto
	{
		public int Id { get; set; }
		public decimal DiscountPercentage { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}

	public class OfferUpdateDto
	{
		public int Id { get; set; }
		public decimal DiscountPercentage { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}

	public class OfferCreateDto
	{
		public decimal DiscountPercentage { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}

}
