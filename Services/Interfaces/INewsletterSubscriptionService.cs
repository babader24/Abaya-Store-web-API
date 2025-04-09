namespace Abaya_Store.Services.Interfaces
{
	public interface INewsletterSubscriptionService
	{
		Task<IEnumerable<NewsletterSubscription>> GetAllAsync();
		Task<NewsletterSubscription?> GetByIdAsync(int id);
		Task<NewsletterSubscription> CreateAsync(NewsletterSubscription subscription);
		Task<bool> UpdateAsync(NewsletterSubscription subscription);
		Task<bool> DeleteAsync(int id);
	}
}
