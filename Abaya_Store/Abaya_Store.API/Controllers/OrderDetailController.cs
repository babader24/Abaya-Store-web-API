using Abaya_Store.Application.DTOs.OrderDetaile;
using Abaya_Store.Application.Features.OrderDetails.Requests.Commands;
using Abaya_Store.Application.Features.OrderDetails.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Abaya_Store.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrderDetailController : ControllerBase
	{
		private readonly IMediator _mediator;

		public OrderDetailController(IMediator mediator)
		{
			_mediator = mediator;
		}
		// GET: api/<BillController>
		[HttpGet]
		public async Task<ActionResult<List<OrderDetailListDto>>> Get()
		{
			var bill = await _mediator.Send(new GetOrderDetailsListRequest());
			return Ok(bill);
		}

		// GET api/<BillController>/5
		[HttpGet("{id}")]
		public async Task<ActionResult<OrderDetailDto>> Get(int id)
		{
			var bill = await _mediator.Send(new GetDetailOrderDetailRequest { Id = id });
			return Ok(bill);
		}

		// POST api/<BillController>
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] OrderDetailCreateDto createDto)
		{
			var command = new CraeteOrderDetailCommand { createDto = createDto };
			var response = await _mediator.Send(command);
			return Ok(response);

		}

		// PUT api/<BillController>/5
		[HttpPut("{id}")]
		public async Task<ActionResult> Put(int id, [FromBody] OrderDetailUpdateDto updateDto)
		{
			var command = new UpdateOrderDetailCommand { updateDto = updateDto };
			await _mediator.Send(command);
			return NoContent();
		}

		// DELETE api/<BillController>/5
		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var command = new DeleteOrderDetailCommand { Id = id };
			await _mediator.Send(command);
			return NoContent();
		}
	}
}
