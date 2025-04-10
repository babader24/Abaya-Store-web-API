using Abaya_Store.Services.Interfaces;
using AbayaStore.Models;
using AbayaStore.Repository.Base;
using AutoMapper;

namespace Abaya_Store.Services
{
	public class WishListService : IWishListService
	{
		private readonly IRepository<WishList> _wishListRepo;
		private readonly IMapper _mapper;

		public WishListService(IRepository<WishList> wishListRepo, IMapper mapper)
		{
			_wishListRepo = wishListRepo;
			_mapper = mapper;
		}

		public async Task<IEnumerable<WishList>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<WishList?> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<WishList> CreateAsync(WishList wishList)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> UpdateAsync(int id, WishList wishList)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}
	}

}
