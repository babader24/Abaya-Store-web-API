using AbayaStore.Models;

namespace Abaya_Store.Services.Interfaces
{
	public interface IShippingInfoService
	{
		Task<IEnumerable<ShippingInfo>> GetAllAsync();
		Task<ShippingInfo?> GetByIdAsync(int id);
		Task<ShippingInfo> CreateAsync(ShippingInfo info);
		Task<bool> UpdateAsync(int id, ShippingInfo info);
		Task<bool> DeleteAsync(int id);
	}
}
