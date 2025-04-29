namespace Abaya_Store.Application.DTOs.Offer
{
	public interface IOfferDto
	{
		public decimal DiscountPercentage { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}

}
