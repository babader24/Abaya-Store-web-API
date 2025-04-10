using AbayaStore.Models;

namespace Abaya_Store.Services.Interfaces
{
	public interface IOfferService
	{
		Task<IEnumerable<Offer>> GetAllAsync();
		Task<Offer?> GetByIdAsync(int id);
		Task<Offer> CreateAsync(Offer offer);
		Task<bool> UpdateAsync(int id, Offer offer);
		Task<bool> DeleteAsync(int id);
	}
}
