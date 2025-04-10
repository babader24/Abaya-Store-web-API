using Abaya_Store.Services.Interfaces;
using AbayaStore.Models;
using AbayaStore.Repository.Base;
using AutoMapper;

namespace Abaya_Store.Services
{
	public class CartItemService : ICartItemService
	{
		private readonly IRepository<CartItem> _cartItemRepo;
		private readonly IMapper _mapper;

		public CartItemService(IRepository<CartItem> cartItemRepo, IMapper mapper)
		{
			_cartItemRepo = cartItemRepo;
			_mapper = mapper;
		}

		public async Task<IEnumerable<CartItem>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<CartItem?> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<CartItem> CreateAsync(CartItem cartItem)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> UpdateAsync(int id, CartItem cartItem)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}
	}

}
