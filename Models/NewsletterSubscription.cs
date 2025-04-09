using AbayaStore.Models;

public class NewsletterSubscription
{
	public int Id { get; set; }
	public int? CustomerId { get; set; }
	public string Email { get; set; }
	public DateTime SubscribedAt { get; set; } = DateTime.Now;
	public bool IsActive { get; set; } = true;

	public virtual Customer? Customer { get; set; }
}

