using Abaya_Store.Services.Interfaces;
using AbayaStore.Models;
using AbayaStore.Repository.Base;
using AutoMapper;

namespace Abaya_Store.Services
{
	public class CustomerService : ICustomerService
	{
		private readonly IRepository<Customer> _customerRepo;
		private readonly IMapper _mapper;

		public CustomerService(IRepository<Customer> customerRepo, IMapper mapper)
		{
			_customerRepo = customerRepo;
			_mapper = mapper;
		}

		public async Task<IEnumerable<Customer>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<Customer?> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<Customer> CreateAsync(Customer customer)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> UpdateAsync(int id, Customer customer)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}
	}

}
