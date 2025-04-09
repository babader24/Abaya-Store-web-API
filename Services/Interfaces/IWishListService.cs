using AbayaStore.Models;

namespace Abaya_Store.Services.Interfaces
{
	public interface IWishListService
	{
		Task<IEnumerable<WishList>> GetAllAsync();
		Task<WishList?> GetByIdAsync(int id);
		Task<WishList> CreateAsync(WishList wishList);
		Task<bool> UpdateAsync(WishList wishList);
		Task<bool> DeleteAsync(int id);
	}
}
