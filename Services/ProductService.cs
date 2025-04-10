using Abaya_Store.Services.Interfaces;
using AbayaStore.Models;
using AbayaStore.Repository.Base;
using AutoMapper;

namespace Abaya_Store.Services
{
	public class ProductService : IProductService
	{
		private readonly IRepository<Product> _productRepo;
		private readonly IMapper _mapper;

		public ProductService(IRepository<Product> productRepo, IMapper mapper)
		{
			_productRepo = productRepo;
			_mapper = mapper;
		}

		public async Task<IEnumerable<Product>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<Product?> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<Product> CreateAsync(Product product)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> UpdateAsync(int id, Product product)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}
	}

}
