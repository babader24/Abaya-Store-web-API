using Abaya_Store.Application.Persistence.Contracts;
using Abaya_Store.Domain.Entities;
using Abaya_Store.Persistence;

namespace Abaya_Store.Presistence.Repositories
{
	public class CustomerRepository : GenaricRepository<Customer>, ICustomerRepository
	{
		private readonly AppDbContext _context;
		public CustomerRepository(AppDbContext context) : base(context)
		{
			_context = context;
		}
	}
}
