using AbayaStore.Models;

namespace Abaya_Store.Services.Interfaces
{
	public interface ICartItemService
	{
		Task<IEnumerable<CartItem>> GetAllAsync();
		Task<CartItem?> GetByIdAsync(int id);
		Task<CartItem> CreateAsync(CartItem cartItem);
		Task<bool> UpdateAsync(int id, CartItem cartItem);
		Task<bool> DeleteAsync(int id);
	}
}
