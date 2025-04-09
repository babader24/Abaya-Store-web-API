using AbayaStore.Models;

namespace Abaya_Store.Services.Interfaces
{
	public interface IOrderDetaileService
	{
		Task<IEnumerable<OrderDetaile>> GetAllAsync();
		Task<OrderDetaile?> GetByIdAsync(int id);
		Task<OrderDetaile> CreateAsync(OrderDetaile orderDetaile);
		Task<bool> UpdateAsync(OrderDetaile orderDetaile);
		Task<bool> DeleteAsync(int id);
	}
}
