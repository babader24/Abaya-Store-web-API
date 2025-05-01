using Abaya_Store.Application.Persistence.Contracts;
using Abaya_Store.Domain.Entities;
using Abaya_Store.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Presistence.Repositories
{
	public class AuditLogRepository : GenaricRepository<AuditLog>, IAuditLogRepository
	{
		private readonly AppDbContext _context;
		public AuditLogRepository(AppDbContext context) : base(context) 
		{
			_context = context;
		}
	}
}
