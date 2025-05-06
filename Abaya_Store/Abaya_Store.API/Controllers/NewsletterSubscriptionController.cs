using Abaya_Store.Application.DTOs.NewsletterSubscription;
using Abaya_Store.Application.Features.NewsletterSubscriptions.Requests.Commands;
using Abaya_Store.Application.Features.NewsletterSubscriptions.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Abaya_Store.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class NewsletterSubscriptionController : ControllerBase
	{
		private readonly IMediator _mediator;

		public NewsletterSubscriptionController(IMediator mediator)
		{
			_mediator = mediator;
		}
		// GET: api/<BillController>
		[HttpGet]
		public async Task<ActionResult<List<NewsletterSubscriptionListDto>>> Get()
		{
			var bill = await _mediator.Send(new GetNewsletterSubscriptionsListRequest());
			return Ok(bill);
		}

		// GET api/<BillController>/5
		[HttpGet("{id}")]
		public async Task<ActionResult<NewsletterSubscriptionDto>> Get(int id)
		{
			var newsletter = await _mediator.Send(new GetDetailNewsletterSubscriptionRequest { Id = id });
			return Ok(newsletter);
		}

		// POST api/<BillController>
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] NewsletterSubscriptionCreateDto createDto)
		{
			var command = new CreateNewsletterSubscriptionsCommand { newsletterSubscription = createDto };
			var response = await _mediator.Send(command);
			return Ok(response);

		}

		// PUT api/<BillController>/5
		[HttpPut("{id}")]
		public async Task<ActionResult> Put(int id, [FromBody] NewsletterSubscriptionUpdateDto updateDto)
		{
			var command = new UpdateNewsletterSubscriptionsCommand { SubscriptionUpdateDto = updateDto };
			await _mediator.Send(command);
			return NoContent();
		}

		// DELETE api/<BillController>/5
		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var command = new DeleteNewsletterSubscriptionsCommand { Id = id };
			await _mediator.Send(command);
			return NoContent();
		}
	}
}
