﻿using Abaya_Store.Application.DTOs.AuditLog;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.AuditLogs.Requests.Commands
{
    public class CreateAuditLogCommand : IRequest<int>
    {
		public AuditLogDto AuditLogDto { get; set; } 
	}

}
