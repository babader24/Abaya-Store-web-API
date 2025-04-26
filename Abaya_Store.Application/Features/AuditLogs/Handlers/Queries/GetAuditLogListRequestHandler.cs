using Abaya_Store.Application.DTOs.AuditLog;
using Abaya_Store.Application.Features.AuditLogs.Requests.Queries;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.AuditLogs.Handlers.Queries
{
	public class GetAuditLogListRequestHandler : IRequestHandler<GetAuditLogListRequest, List<AuditLogDto>>
	{
		private readonly IAuditLogRepository _auditLogRepository;
		private readonly IMapper _mapper;

		public GetAuditLogListRequestHandler(IAuditLogRepository auditLogRepository, IMapper mapper)
		{
			_auditLogRepository = auditLogRepository;
			_mapper = mapper;
		}

		public async Task<List<AuditLogDto>> Handle(GetAuditLogListRequest request, CancellationToken cancellationToken)
		{
			var AuditLogs = await _auditLogRepository.GetAllIncludingAsync();
			return _mapper.Map<List<AuditLogDto>>(AuditLogs);
		}
	}
}
