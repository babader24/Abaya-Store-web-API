namespace AbayaStore.Models
{
	public class Customer : Person
	{
		public DateTime RegisterDate { get; set; } = DateTime.Now;
		public bool IsSubscribedToNewsletter { get; set; } = false;
		public string? Notes { get; set; } 

		public virtual Cart Cart { get; set; }
		public virtual WishList WishList { get; set; }
		public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();
		public virtual ICollection<ProductReview> Reviews { get; set; } = new List<ProductReview>();
		public virtual ICollection<NewsletterSubscription> NewsletterSubscriptions { get; set; } = new List<NewsletterSubscription>();
	}
}
