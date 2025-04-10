using Abaya_Store.Services.Interfaces;
using AbayaStore.Models;
using AbayaStore.Repository.Base;
using AutoMapper;

namespace Abaya_Store.Services
{
	public class ProductReviewService : IProductReviewService
	{
		private readonly IRepository<ProductReview> _reviewRepo;
		private readonly IMapper _mapper;

		public ProductReviewService(IRepository<ProductReview> reviewRepo, IMapper mapper)
		{
			_reviewRepo = reviewRepo;
			_mapper = mapper;
		}

		public async Task<IEnumerable<ProductReview>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<ProductReview?> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<ProductReview> CreateAsync(ProductReview review)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> UpdateAsync(int id, ProductReview review)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}
	}

}
