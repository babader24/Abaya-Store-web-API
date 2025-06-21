using Abaya_Store.Application.DTOs.Customer;
using Abaya_Store.Application.Features.Customers.Requests.Commands;
using Abaya_Store.Application.Features.Customers.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Abaya_Store.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		private readonly IMediator _mediator;

		public CustomerController(IMediator mediator)
		{
			_mediator = mediator;
		}
		// GET: api/<customerController>
		[HttpGet]
		public async Task<ActionResult<List<CustomerListDto>>> Get()
		{
			var customer = await _mediator.Send(new GetCustomerListRequest());
			return Ok(customer);
		}

		// GET api/<customerController>/5
		[HttpGet("{id}")]
		[Authorize]
		public async Task<ActionResult<CustomerDto>> Get(int id)
		{
			var customer = await _mediator.Send(new GetDetailCustomerRequest { Id = id });
			return Ok(customer);
		}

		// POST api/<customerController>
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] CustomerCreateDto customerCreateDto)
		{
			var command = new CreateCustomerCommand { CustomerCreateDto = customerCreateDto };
			var response = await _mediator.Send(command);
			return Ok(response);

		}

		// PUT api/<customerController>/5
		[HttpPut("{id}")]
		public async Task<ActionResult> Put(int id, [FromBody] CustomerUpdateDto customerUpdateDto)
		{
			var command = new UpdateCustomerCommand { CustomerUpdateDto = customerUpdateDto };
			await _mediator.Send(command);
			return NoContent();
		}

		// DELETE api/<BillController>/5
		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var command = new DeleteCustomerCommand { Id = id };
			await _mediator.Send(command);
			return NoContent();
		}
	}
}
