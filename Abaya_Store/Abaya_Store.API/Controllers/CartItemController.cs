using Abaya_Store.Application.DTOs.CartItem;
using Abaya_Store.Application.Features.CartItems.Requests.Commands;
using Abaya_Store.Application.Features.CartItems.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Abaya_Store.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CartItemController : ControllerBase
	{
		private readonly IMediator _mediator;

		public CartItemController(IMediator mediator)
		{
			_mediator = mediator;
		}
		// GET: api/<BillController>
		[HttpGet]
		public async Task<ActionResult<List<CartItemListDto>>> Get()
		{
			var cartItem = await _mediator.Send(new GetCartItemsListRequest());
			return Ok(cartItem);
		}


		// POST api/<BillController>
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] CartItemCreateDto cartItemCreateDto)
		{
			var command = new CreateCartItemCommand { createDto  = cartItemCreateDto };
			var response = await _mediator.Send(command);
			return Ok(response);

		}

		// DELETE api/<BillController>/5
		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var command = new DeleteCartItemCommand { Id = id };
			await _mediator.Send(command);
			return NoContent();
		}
	}
}
