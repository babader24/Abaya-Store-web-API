using Abaya_Store.Application.DTOs.Offer;
using Abaya_Store.Application.Features.Offers.Requests.Commands;
using Abaya_Store.Application.Features.Offers.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Abaya_Store.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OfferController : ControllerBase
	{
		private readonly IMediator _mediator;

		public OfferController(IMediator mediator)
		{
			_mediator = mediator;
		}
		// GET: api/<BillController>
		[HttpGet]
		public async Task<ActionResult<List<OfferListDto>>> Get()
		{
			var offer = await _mediator.Send(new GetOffersListRequest());
			return Ok(offer);
		}

		// GET api/<BillController>/5
		[HttpGet("{id}")]
		public async Task<ActionResult<OfferDto>> Get(int id)
		{
			var offer = await _mediator.Send(new GetOfferDetailRequest { Id = id });
			return Ok(offer);
		}

		// POST api/<BillController>
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] OfferCreateDto createDto)
		{
			var command = new CreateOfferCommand { createDto = createDto };
			var response = await _mediator.Send(command);
			return Ok(response);

		}

		// PUT api/<BillController>/5
		[HttpPut("{id}")]
		public async Task<ActionResult> Put(int id, [FromBody] OfferUpdateDto updateDto)
		{
			var command = new UpdateOfferCommand { updateDto = updateDto };
			await _mediator.Send(command);
			return NoContent();
		}

		// DELETE api/<BillController>/5
		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var command = new DeleteOfferCommand { Id = id };
			await _mediator.Send(command);
			return NoContent();
		}
	}
}
