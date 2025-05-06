using Abaya_Store.Application.DTOs.Cart;
using Abaya_Store.Application.Features.Carts.Requests.Commands;
using Abaya_Store.Application.Features.Carts.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Abaya_Store.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CartController : ControllerBase
	{
		private readonly IMediator _mediator;

		public CartController(IMediator mediator)
		{
			_mediator = mediator;
		}
		// GET: api/<BillController>
		[HttpGet]
		public async Task<ActionResult<List<CartListDto>>> Get()
		{
			var cart = await _mediator.Send(new GetListCartRequest());
			return Ok(cart);
		}

		// GET api/<BillController>/5
		[HttpGet("{id}")]
		public async Task<ActionResult<CartDto>> Get(int id)
		{
			var cart = await _mediator.Send(new GetDetailCartRequest { Id = id });
			return Ok(cart);
		}

		// POST api/<BillController>
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] CartCreateDto cart)
		{
			var command = new CreateCartCommand { CartDto = cart };
			var response = await _mediator.Send(command);
			return Ok(response);

		}

	}
}
