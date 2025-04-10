using AbayaStore.Models;

namespace Abaya_Store.Services.Interfaces
{
	public interface IOfferProductService
	{
		Task<IEnumerable<OfferProduct>> GetAllAsync();
		Task<OfferProduct?> GetByIdAsync(int id);
		Task<OfferProduct> CreateAsync(OfferProduct offerProduct);
		Task<bool> UpdateAsync(int id, OfferProduct offerProduct);
		Task<bool> DeleteAsync(int id);
	}
}
