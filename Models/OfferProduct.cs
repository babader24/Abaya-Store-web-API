namespace AbayaStore.Models
{
	public class OfferProduct
	{
		public int Id { get; set; }
		public int OfferId { get; set; }
		public int ProductId { get; set; }

		public virtual Offer Offer { get; set; }
		public virtual Product Product { get; set; }
	}
}
