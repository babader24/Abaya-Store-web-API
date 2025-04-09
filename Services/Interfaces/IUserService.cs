using AbayaStore.Models;

namespace Abaya_Store.Services.Interfaces
{
	public interface IUserService
	{
		Task<IEnumerable<User>> GetAllAsync();
		Task<User?> GetByIdAsync(int id);
		Task<User> CreateAsync(User user);
		Task<bool> UpdateAsync(User user);
		Task<bool> DeleteAsync(int id);
	}
}
