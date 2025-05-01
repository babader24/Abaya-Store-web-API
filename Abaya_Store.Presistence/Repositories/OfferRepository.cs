using Abaya_Store.Application.Persistence.Contracts;
using Abaya_Store.Domain.Entities;
using Abaya_Store.Persistence;

namespace Abaya_Store.Presistence.Repositories
{
	public class OfferRepository : GenaricRepository<Offer>, IOfferRepository
	{
		private readonly AppDbContext _context;
		public OfferRepository(AppDbContext context) : base(context)
		{
			_context = context;
		}
	}
}
