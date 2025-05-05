using Abaya_Store.Application.DTOs.AuditLog;
using Abaya_Store.Application.Features.AuditLogs.Requests.Commands;
using Abaya_Store.Application.Features.AuditLogs.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Abaya_Store.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuditLogController : ControllerBase
	{
		private readonly IMediator _mediator;

		public AuditLogController(IMediator mediator)
		{
			_mediator = mediator;
		}
		// GET: api/<BillController>
		[HttpGet]
		public async Task<ActionResult<List<AuditLogDto>>> Get()
		{
			var audits = await _mediator.Send(new GetAuditLogListRequest());
			return Ok(audits);
		}

		// GET api/<BillController>/5
		[HttpGet("{id}")]
		public async Task<ActionResult<AuditLogDto>> Get(int id)
		{
			var audits = await _mediator.Send(new GetAuditLogDetailRequest { Id = id });
			return Ok(audits);
		}

		// POST api/<BillController>
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] AuditLogDto auditLogDto)
		{
			var command = new CreateAuditLogCommand { AuditLogDto = auditLogDto };
			var response = await _mediator.Send(command);
			return Ok(response);

		}


	}
}
