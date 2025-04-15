namespace AbayaStore.Models
{
	public class WishList
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public virtual Customer Customer { get; set; }
		public virtual ICollection<WishListItem> Items { get; set; } = new List<WishListItem>();
	}
}
