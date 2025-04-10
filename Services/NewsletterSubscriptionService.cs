using Abaya_Store.Services.Interfaces;
using AbayaStore.Repository.Base;
using AutoMapper;

namespace Abaya_Store.Services
{
	public class NewsletterSubscriptionService : INewsletterSubscriptionService
	{
		private readonly IRepository<NewsletterSubscription> _newsletterSubscriptionRepo;
		private readonly IMapper _mapper;

		public NewsletterSubscriptionService(IRepository<NewsletterSubscription> newsletterSubscriptionRepo, IMapper mapper)
		{
			_newsletterSubscriptionRepo = newsletterSubscriptionRepo;
			_mapper = mapper;
		}

		public async Task<IEnumerable<NewsletterSubscription>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<NewsletterSubscription?> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<NewsletterSubscription> CreateAsync(NewsletterSubscription subscription)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> UpdateAsync(int id, NewsletterSubscription subscription)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}
	}

}
