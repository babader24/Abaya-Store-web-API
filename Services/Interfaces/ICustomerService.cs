using AbayaStore.Models;

namespace Abaya_Store.Services.Interfaces
{
	public interface ICustomerService
	{
		Task<IEnumerable<Customer>> GetAllAsync();
		Task<Customer?> GetByIdAsync(int id);
		Task<Customer> CreateAsync(Customer customer);
		Task<bool> UpdateAsync(Customer customer);
		Task<bool> DeleteAsync(int id);
	}
}
