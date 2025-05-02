using Abaya_Store.Application.Contracts.Persistence;
using Abaya_Store.Domain.Entities;
using Abaya_Store.Persistence;

namespace Abaya_Store.Presistence.Repositories
{
	public class CategoryRepository : GenaricRepository<Category>, ICategoryRepository
	{
		private readonly AppDbContext _context;
		public CategoryRepository(AppDbContext context) : base(context)
		{
			_context = context;
		}
	}
}
