using Abaya_Store.Services.Interfaces;
using namespace Abaya_Store.Domain.Entities;
using AbayaStore.Repository.Base;
using AutoMapper;

namespace Abaya_Store.Services
{
	public class AuditLogService : IAuditLogService
	{
		private readonly IRepository<AuditLog> _auditLogRepo;
		private readonly IMapper _mapper;

		public AuditLogService(IRepository<AuditLog> auditLogRepo, IMapper mapper)
		{
			_auditLogRepo = auditLogRepo;
			_mapper = mapper;
		}

		public async Task<IEnumerable<AuditLog>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<AuditLog?> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<AuditLog> CreateAsync(AuditLog auditLog)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> UpdateAsync(int id, AuditLog auditLog)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}
	}
}
