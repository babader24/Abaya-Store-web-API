﻿using AbayaStore.Models;

namespace Abaya_Store.Services.Interfaces
{
	public interface IProductService
	{
		Task<IEnumerable<Product>> GetAllAsync();
		Task<Product?> GetByIdAsync(int id);
		Task<Product> CreateAsync(Product product);
		Task<bool> UpdateAsync(int id, Product product);
		Task<bool> DeleteAsync(int id);
	}
}
