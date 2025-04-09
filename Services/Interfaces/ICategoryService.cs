﻿using AbayaStore.Models;

namespace Abaya_Store.Services.Interfaces
{
	public interface ICategoryService
	{
		Task<IEnumerable<Category>> GetAllAsync();
		Task<Category?> GetByIdAsync(int id);
		Task<Category> CreateAsync(Category category);
		Task<bool> UpdateAsync(Category category);
		Task<bool> DeleteAsync(int id);
	}
}
