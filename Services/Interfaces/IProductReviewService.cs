using AbayaStore.Models;

namespace Abaya_Store.Services.Interfaces
{
	public interface IProductReviewService
	{
		Task<IEnumerable<ProductReview>> GetAllAsync();
		Task<ProductReview?> GetByIdAsync(int id);
		Task<ProductReview> CreateAsync(ProductReview review);
		Task<bool> UpdateAsync(ProductReview review);
		Task<bool> DeleteAsync(int id);
	}
}
