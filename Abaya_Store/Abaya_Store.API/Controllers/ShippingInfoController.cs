using Abaya_Store.Application.DTOs.ShippingInfo;
using Abaya_Store.Application.Features.ShippingInfos.Requests.Commands;
using Abaya_Store.Application.Features.ShippingInfos.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Abaya_Store.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ShippingInfoController : ControllerBase
	{
		private readonly IMediator _mediator;

		public ShippingInfoController(IMediator mediator)
		{
			_mediator = mediator;
		}
		// GET: api/<BillController>
		[HttpGet]
		public async Task<ActionResult<List<ShippingInfoListDto>>> Get()
		{
			var bill = await _mediator.Send(new GetShippingInfosListRequest());
			return Ok(bill);
		}

		// GET api/<BillController>/5
		[HttpGet("{id}")]
		public async Task<ActionResult<ShippingInfoDto>> Get(int id)
		{
			var bill = await _mediator.Send(new GetShippingInfoDetailRequest { Id = id });
			return Ok(bill);
		}

		// POST api/<BillController>
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] ShippingInfoCreateDto createDto)
		{
			var command = new CreateShippingInfoCommand { createDto = createDto };
			var response = await _mediator.Send(command);
			return Ok(response);

		}

		// PUT api/<BillController>/5
		[HttpPut("{id}")]
		public async Task<ActionResult> Put(int id, [FromBody] ShippingInfoUpdateDto updateDto)
		{
			var command = new UpdateShippingInfoCommand { updateDto = updateDto };
			await _mediator.Send(command);
			return NoContent();
		}

		// DELETE api/<BillController>/5
		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var command = new DeleteShippingInfoCommand { Id = id };
			await _mediator.Send(command);
			return NoContent();
		}
	}
}
