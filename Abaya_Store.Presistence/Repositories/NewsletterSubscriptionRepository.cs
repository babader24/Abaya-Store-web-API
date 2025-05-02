using Abaya_Store.Application.Contracts.Persistence;
using Abaya_Store.Domain.Entities;
using Abaya_Store.Persistence;

namespace Abaya_Store.Presistence.Repositories
{
	public class NewsletterSubscriptionRepository : GenaricRepository<NewsletterSubscription>, INewsletterSubscriptionRepository
	{
		private readonly AppDbContext _context;
		public NewsletterSubscriptionRepository(AppDbContext context) : base(context)
		{
			_context = context;
		}
	}
}
