using AbayaStore.Models;

namespace Abaya_Store.Services.Interfaces
{
	public interface IBillService
	{
		Task<IEnumerable<Bill>> GetAllAsync();
		Task<Bill?> GetByIdAsync(int id);
		Task<Bill> CreateAsync(Bill bill);
		Task<bool> UpdateAsync(int id, Bill bill);
		Task<bool> DeleteAsync(int id);
	}
}
