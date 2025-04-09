using System.Linq.Expressions;

namespace AbayaStore.Repository.Base
{
	public interface IRepository<T> where T : class
	{
		Task<IEnumerable<T>> GetAllAsync();

		Task<T> GetByIdAsync(int Id);

		Task<T> AddAsync(T Entity);
		Task UpdateAsync(T Entity);
		Task DeleteAsync(T Entity);

		//اضافات خارج الجنريك ريبو
		Task<IEnumerable<T>> GetAllIncludingAsync(params Expression<Func<T, object>>[] includeProperties);
		Task<T> GetByIdIncludeAsync(int id, params Expression<Func<T, object>>[] includes);

	}
}
