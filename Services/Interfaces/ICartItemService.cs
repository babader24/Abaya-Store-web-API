using AbayaStore.Models;

namespace Abaya_Store.Services.Interfaces
{
	public interface ICartItemService
	{
		Task<IEnumerable<CartItem>> GetAllAsync();
		Task<CartItem?> GetByIdAsync(int id);
		Task<CartItem> CreateAsync(CartItem cartItem);
		Task<bool> UpdateAsync(CartItem cartItem);
		Task<bool> DeleteAsync(int id);
	}
}
