using AbayaStore.Models;

namespace Abaya_Store.Services.Interfaces
{
	public interface IAuditLogService
	{
		Task<IEnumerable<AuditLog>> GetAllAsync();
		Task<AuditLog?> GetByIdAsync(int id);
		Task<AuditLog> CreateAsync(AuditLog auditLog);
		Task<bool> UpdateAsync(int id, AuditLog auditLog);
		Task<bool> DeleteAsync(int id);
	}
}
