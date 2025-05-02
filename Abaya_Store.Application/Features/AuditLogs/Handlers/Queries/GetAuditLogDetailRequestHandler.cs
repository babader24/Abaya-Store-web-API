using Abaya_Store.Application.DTOs.AuditLog;
using Abaya_Store.Application.Features.AuditLogs.Requests.Queries;
using Abaya_Store.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.AuditLogs.Handlers.Queries
{
	public class GetAuditLogDetailRequestHandler : IRequestHandler<GetAuditLogDetailRequest, AuditLogDto>
	{
		private readonly IAuditLogRepository _auditLogRepository;
		private readonly IMapper _mapper;

		public GetAuditLogDetailRequestHandler(IAuditLogRepository auditLogRepository, IMapper mapper)
		{
			_auditLogRepository = auditLogRepository;
			_mapper = mapper;
		}

		public async Task<AuditLogDto> Handle(GetAuditLogDetailRequest request, CancellationToken cancellationToken)
		{
			var AuditLog = await _auditLogRepository.GetByIdIncludeAsync(request.Id);

			return _mapper.Map<AuditLogDto>(AuditLog);
		}
	}
}
