namespace Abaya_Store.Domain.Entities
{
	public class Cart
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public virtual Customer Customer { get; set; }
		public virtual ICollection<CartItem> Items { get; set; } = new List<CartItem>();
	}
}
