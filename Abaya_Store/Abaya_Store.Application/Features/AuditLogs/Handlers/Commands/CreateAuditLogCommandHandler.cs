using Abaya_Store.Application.Features.AuditLogs.Requests.Commands;
using Abaya_Store.Application.Contracts.Persistence;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.AuditLogs.Handlers.Commands
{
	public class CreateAuditLogCommandHandler : IRequestHandler<CreateAuditLogCommand, int>
	{
		private readonly IAuditLogRepository _auditLogRepository;
		private readonly IMapper _mapper;

		public CreateAuditLogCommandHandler(IAuditLogRepository auditLogRepository, IMapper mapper)
		{
			_auditLogRepository = auditLogRepository;
			_mapper = mapper;
		}
		public async Task<int> Handle(CreateAuditLogCommand request, CancellationToken cancellationToken)
		{
			var auditLog = _mapper.Map<AuditLog>(request.AuditLogDto);

			auditLog = await _auditLogRepository.AddAsync(auditLog);

			return auditLog.Id;
		}
	}
}
