using AbayaStore.Models;

namespace Abaya_Store.Services.Interfaces
{
	public interface IWishListItemService
	{
		Task<IEnumerable<WishListItem>> GetAllAsync();
		Task<WishListItem?> GetByIdAsync(int id);
		Task<WishListItem> CreateAsync(WishListItem item);
		Task<bool> UpdateAsync(WishListItem item);
		Task<bool> DeleteAsync(int id);
	}
}
