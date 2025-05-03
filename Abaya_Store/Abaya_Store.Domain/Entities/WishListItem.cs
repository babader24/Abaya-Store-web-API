namespace Abaya_Store.Domain.Entities
{
	public class WishListItem
	{
		public int Id { get; set; }
		public int WishListId { get; set; }
		public int ProductId { get; set; }
		public DateTime DateAdded { get; set; } = DateTime.Now;

		public virtual WishList WishList { get; set; }
		public virtual Product Product { get; set; }
	}
}
