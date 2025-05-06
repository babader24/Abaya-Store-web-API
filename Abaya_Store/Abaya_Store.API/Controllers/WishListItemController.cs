using Abaya_Store.Application.DTOs.WishListItem;
using Abaya_Store.Application.Features.WishListItems.Requests.Commands;
using Abaya_Store.Application.Features.WishListItems.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Abaya_Store.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WishListItemController : ControllerBase
	{
		private readonly IMediator _mediator;

		public WishListItemController(IMediator mediator)
		{
			_mediator = mediator;
		}
		// GET: api/<BillController>
		[HttpGet]
		public async Task<ActionResult<List<WishListItemListfDto>>> Get()
		{
			var wishListItem = await _mediator.Send(new GetWishListItemsRequest());
			return Ok(wishListItem);
		}

		// GET api/<BillController>/5
		[HttpGet("{id}")]
		public async Task<ActionResult<WishListItemDto>> Get(int id)
		{
			var wishListItem = await _mediator.Send(new GetWishListItemDetailRequest { Id = id });
			return Ok(wishListItem);
		}

		// POST api/<BillController>
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] WishListItemCreateDto createDto)
		{
			var command = new CreateWishListItemCommand { CreateDto = createDto };
			var response = await _mediator.Send(command);
			return Ok(response);

		}

		// PUT api/<BillController>/5
		[HttpPut("{id}")]
		public async Task<ActionResult> Put(int id, [FromBody] WishListItemUpdateDto updateDto)
		{
			var command = new UpdateWishListItemCommand { UpdateDto = updateDto };
			await _mediator.Send(command);
			return NoContent();
		}

		// DELETE api/<BillController>/5
		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var command = new DeleteWishListItemCommand { Id = id };
			await _mediator.Send(command);
			return NoContent();
		}
	}
}
