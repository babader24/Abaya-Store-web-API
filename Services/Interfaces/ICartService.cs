using AbayaStore.Models;

namespace Abaya_Store.Services.Interfaces
{
	public interface ICartService
	{
		Task<IEnumerable<Cart>> GetAllAsync();
		Task<Cart?> GetByIdAsync(int id);
		Task<Cart> CreateAsync(Cart cart);
		Task<bool> UpdateAsync(int id, Cart cart);
		Task<bool> DeleteAsync(int id);
	}
}
