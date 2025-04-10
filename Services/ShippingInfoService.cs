using Abaya_Store.Services.Interfaces;
using AbayaStore.Models;
using AbayaStore.Repository.Base;
using AutoMapper;

namespace Abaya_Store.Services
{
	public class ShippingInfoService : IShippingInfoService
	{
		private readonly IRepository<ShippingInfo> _shippingRepo;
		private readonly IMapper _mapper;

		public ShippingInfoService(IRepository<ShippingInfo> shippingRepo, IMapper mapper)
		{
			_shippingRepo = shippingRepo;
			_mapper = mapper;
		}

		public async Task<IEnumerable<ShippingInfo>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<ShippingInfo?> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<ShippingInfo> CreateAsync(ShippingInfo info)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> UpdateAsync(int id, ShippingInfo info)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}
	}

}
