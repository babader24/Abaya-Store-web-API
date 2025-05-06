using Abaya_Store.Application.DTOs.PaymentTransaction;
using Abaya_Store.Application.Features.PaymentTransactions.Requests.Commands;
using Abaya_Store.Application.Features.PaymentTransactions.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Abaya_Store.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PaymentTransactionController : ControllerBase
	{
		private readonly IMediator _mediator;

		public PaymentTransactionController(IMediator mediator)
		{
			_mediator = mediator;
		}
		// GET: api/<BillController>
		[HttpGet]
		public async Task<ActionResult<List<PaymentTransactionListDto>>> Get()
		{
			var payment = await _mediator.Send(new GetPaymentTransactionsListRequest());
			return Ok(payment);
		}

		// GET api/<BillController>/5
		[HttpGet("{id}")]
		public async Task<ActionResult<PaymentTransactionDto>> Get(int id)
		{
			var payment = await _mediator.Send(new GetPaymentTransactionDetail { Id = id });
			return Ok(payment);
		}

		// POST api/<BillController>
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] PaymentTransactionCreateDto  createDto)
		{
			var command = new CreatePaymentTransactionCommand { createDto = createDto };
			var response = await _mediator.Send(command);
			return Ok(response);

		}

		// PUT api/<BillController>/5
		[HttpPut("{id}")]
		public async Task<ActionResult> Put(int id, [FromBody] PaymentTransactionUpdateDto  updateDto)
		{
			var command = new UpdatePaymentTransactionCommand { updateDto = updateDto };
			await _mediator.Send(command);
			return NoContent();
		}

		// DELETE api/<BillController>/5
		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var command = new DeletePaymentTransactionCommand { Id = id };
			await _mediator.Send(command);
			return NoContent();
		}
	}
}
