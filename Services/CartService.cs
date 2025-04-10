using Abaya_Store.Services.Interfaces;
using AbayaStore.Models;
using AbayaStore.Repository.Base;
using AutoMapper;

namespace Abaya_Store.Services
{
	public class CartService : ICartService
	{
		private readonly IRepository<Cart> _cartRepo;
		private readonly IMapper _mapper;

		public CartService(IRepository<Cart> cartRepo, IMapper mapper)
		{
			_cartRepo = cartRepo;
			_mapper = mapper;
		}

		public async Task<IEnumerable<Cart>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<Cart?> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<Cart> CreateAsync(Cart cart)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> UpdateAsync(int id, Cart cart)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}
	}

}
