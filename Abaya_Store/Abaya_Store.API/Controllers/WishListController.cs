using Abaya_Store.Application.DTOs.WishList;
using Abaya_Store.Application.Features.WishLists.Requests.Commands;
using Abaya_Store.Application.Features.WishLists.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Abaya_Store.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WishListController : ControllerBase
	{
		private readonly IMediator _mediator;

		public WishListController(IMediator mediator)
		{
			_mediator = mediator;
		}
		// GET: api/<BillController>
		[HttpGet]
		public async Task<ActionResult<List<WishListListDto>>> Get()
		{
			var wishList = await _mediator.Send(new GetWishListsRequest());
			return Ok(wishList);
		}

		// GET api/<BillController>/5
		[HttpGet("{id}")]
		public async Task<ActionResult<WishListDto>> Get(int id)
		{
			var wishList = await _mediator.Send(new GetWishListDetailRequest { Id = id });
			return Ok(wishList);
		}

		// POST api/<BillController>
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] WishListCreateDto createDto)
		{
			var command = new CreateWishListCommand { CreateDto = createDto };
			var response = await _mediator.Send(command);
			return Ok(response);

		}

		// DELETE api/<BillController>/5
		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var command = new DeleteWishListCommand { Id = id };
			await _mediator.Send(command);
			return NoContent();
		}
	}
}
