using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Persistence.Contracts
{
    public interface IGenaricRepository<T> where T : class
    {
		Task<IReadOnlyList<T>> GetAllAsyncReadOnlyList();
		Task<IEnumerable<T>> GetAllAsync();
		Task<T> GetByIdAsync(int Id);

		Task<T> AddAsync(T Entity);
		Task UpdateAsync(T Entity);
		Task DeleteAsync(T Entity);

		Task<IEnumerable<T>> GetAllIncludingAsync(params Expression<Func<T, object>>[] includeProperties);
		Task<T> GetByIdIncludeAsync(int id, params Expression<Func<T, object>>[] includes);
	}
}
