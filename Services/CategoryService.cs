using Abaya_Store.Services.Interfaces;
using AbayaStore.Models;
using AbayaStore.Repository.Base;
using AutoMapper;

namespace Abaya_Store.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly IRepository<Category> _categoryRepo;
		private readonly IMapper _mapper;

		public CategoryService(IRepository<Category> categoryRepo, IMapper mapper)
		{
			_categoryRepo = categoryRepo;
			_mapper = mapper;
		}

		public async Task<IEnumerable<Category>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<Category?> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<Category> CreateAsync(Category category)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> UpdateAsync(int id, Category category)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}
	}

}
