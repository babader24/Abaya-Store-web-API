using Abaya_Store.Application.DTOs.OfferProduct;
using Abaya_Store.Application.Features.OfferProducts.Requests.Commands;
using Abaya_Store.Application.Features.OfferProducts.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Abaya_Store.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OfferProductController : ControllerBase
	{
		private readonly IMediator _mediator;

		public OfferProductController(IMediator mediator)
		{
			_mediator = mediator;
		}
		// GET: api/<BillController>
		[HttpGet]
		public async Task<ActionResult<List<OfferProductListDto>>> Get()
		{
			var offerProduct = await _mediator.Send(new GetOfferProductsListRequest());
			return Ok(offerProduct);
		}

		// GET api/<BillController>/5
		[HttpGet("{id}")]
		public async Task<ActionResult<OfferProductDto>> Get(int id)
		{
			var offerProduct = await _mediator.Send(new GetDetailOfferProductRequest { Id = id });
			return Ok(offerProduct);
		}

		// POST api/<BillController>
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] OfferProductCreateDto createDto)
		{
			var command = new CraeteOfferProductCommand { createDto = createDto };
			var response = await _mediator.Send(command);
			return Ok(response);

		}

		// PUT api/<BillController>/5
		[HttpPut("{id}")]
		public async Task<ActionResult> Put(int id, [FromBody] OfferProductUpdateDto updateDto)
		{
			var command = new UpdateOfferProductCommand { updateDto = updateDto };
			await _mediator.Send(command);
			return NoContent();
		}

		// DELETE api/<BillController>/5
		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var command = new DeleteOfferProductCommand { Id = id };
			await _mediator.Send(command);
			return NoContent();
		}
	}
}
