using Abaya_Store.Services.Interfaces;
using AbayaStore.Models;
using AbayaStore.Repository.Base;
using AutoMapper;

namespace Abaya_Store.Services
{
	public class BillService : IBillService
	{
		private readonly IRepository<Bill> _billRepo;
		private readonly IMapper _mapper;

		public BillService(IRepository<Bill> billRepo, IMapper mapper)
		{
			_billRepo = billRepo;
			_mapper = mapper;
		}

		public async Task<IEnumerable<Bill>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<Bill?> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<Bill> CreateAsync(Bill bill)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> UpdateAsync(int id, Bill bill)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}
	}
}
