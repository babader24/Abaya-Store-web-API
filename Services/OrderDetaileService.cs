using Abaya_Store.Services.Interfaces;
using AbayaStore.Models;
using AbayaStore.Repository.Base;
using AutoMapper;

namespace Abaya_Store.Services
{
	public class OrderDetaileService : IOrderDetaileService
	{
		private readonly IRepository<OrderDetaile> _orderDetaileRepo;
		private readonly IMapper _mapper;

		public OrderDetaileService(IRepository<OrderDetaile> orderDetaileRepo, IMapper mapper)
		{
			_orderDetaileRepo = orderDetaileRepo;
			_mapper = mapper;
		}

		public async Task<IEnumerable<OrderDetaile>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<OrderDetaile?> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<OrderDetaile> CreateAsync(OrderDetaile orderDetaile)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> UpdateAsync(int id, OrderDetaile orderDetaile)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}
	}

}
