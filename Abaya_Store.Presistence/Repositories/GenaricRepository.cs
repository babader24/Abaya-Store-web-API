using Abaya_Store.Application.Contracts.Persistence;
using Abaya_Store.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Presistence.Repositories
{
	public class GenaricRepository<T> : IGenaricRepository<T> where T : class
	{
		private readonly AppDbContext _context;
		private readonly DbSet<T> _dbSet;

		public GenaricRepository(AppDbContext context)
		{
			_context = context;
			_dbSet = _context.Set<T>();
		}

		public async Task<IEnumerable<T>> GetAllAsync()
		{
			return await _dbSet.ToListAsync();
		}

		public async Task<IReadOnlyList<T>> GetAllAsyncReadOnlyList()
		{
			return await _dbSet.ToListAsync();
		}

		public async Task<T> GetByIdAsync(int Id)
		{
			//return await _dbSet.FindAsync(Id);
			var entity = await _dbSet.FindAsync(Id);

			//if (entity == null)
			//	throw new KeyNotFoundException($"Entity of type {typeof(T).Name} with ID {Id} was not found.");

			return entity;
		}
		public async Task<T> AddAsync(T Entity)
		{
			await _dbSet.AddAsync(Entity);
			await _context.SaveChangesAsync();
			return Entity;
		}

		public async Task UpdateAsync(T Entity)
		{
			_dbSet.Attach(Entity);
			_context.Entry(Entity).State = EntityState.Modified;
			await _context.SaveChangesAsync();
		}

		public async Task DeleteAsync(T Entity)
		{
			_dbSet.Remove(Entity);
			await _context.SaveChangesAsync();
		}

		// اضافات حارج الريبو

		public async Task<IEnumerable<T>> GetAllIncludingAsync(params Expression<Func<T, object>>[] includeProperties)
		{
			IQueryable<T> query = _context.Set<T>();
			foreach (var includeProperty in includeProperties)
			{
				query = query.Include(includeProperty);
			}
			return await query.ToListAsync();
		}

		public async Task<T> GetByIdIncludeAsync(int id, params Expression<Func<T, object>>[] includes)
		{
			IQueryable<T> query = _dbSet;

			// الحصول على اسم الخاصية الأساسية للكيان بشكل ديناميكي
			var entityType = _context.Model.FindEntityType(typeof(T));
			var primaryKey = entityType.FindPrimaryKey();

			if (primaryKey.Properties.Count != 1)
			{
				throw new InvalidOperationException("لا يدعم الكيانات ذات المفاتيح الأساسية المركبة");
			}

			var primaryKeyProperty = primaryKey.Properties[0];
			string primaryKeyName = primaryKeyProperty.Name;
			Type primaryKeyType = primaryKeyProperty.ClrType;

			// بناء تعبير Lambda ديناميكي
			var parameter = Expression.Parameter(typeof(T), "e");
			var property = Expression.Property(parameter, primaryKeyName);
			var constant = Expression.Constant(id);
			var body = Expression.Equal(property, constant);
			var lambda = Expression.Lambda<Func<T, bool>>(body, parameter);

			foreach (var include in includes)
			{
				query = query.Include(include);
			}
			return await query.FirstOrDefaultAsync(lambda);
		}

	}
}
