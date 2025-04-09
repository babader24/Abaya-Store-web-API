namespace AbayaStore.Models
{
	public class Offer
	{
		public int Id { get; set; }
		public decimal DiscountPercentage { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		public virtual ICollection<OfferProduct> Products { get; set; } = new List<OfferProduct>();
	}
}
