using Abaya_Store.Application.DTOs.AuditLog;
using MediatR;

namespace Abaya_Store.Application.Features.AuditLogs.Requests.Queries
{
	public class GetAuditLogDetailRequest : IRequest<AuditLogDto>
	{
		public int Id { get; set; }
	}
}
