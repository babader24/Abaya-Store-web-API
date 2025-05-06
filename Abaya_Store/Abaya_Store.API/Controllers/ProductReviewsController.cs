using Abaya_Store.Application.DTOs.ProductReview;
using Abaya_Store.Application.Features.ProductReviews.Requests.Commands;
using Abaya_Store.Application.Features.ProductReviews.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Abaya_Store.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductReviewsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public ProductReviewsController(IMediator mediator)
		{
			_mediator = mediator;
		}
		// GET: api/<BillController>
		[HttpGet]
		public async Task<ActionResult<List<ProductReviewListDto>>> Get()
		{
			var productReview = await _mediator.Send(new GetProductReviewsListRequest());
			return Ok(productReview);
		}

		// GET api/<BillController>/5
		[HttpGet("{id}")]
		public async Task<ActionResult<ProductReviewDto>> Get(int id)
		{
			var productReview = await _mediator.Send(new GetProductReviewDetailRequest { Id = id });
			return Ok(productReview);
		}

		// POST api/<BillController>
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] ProductReviewCreateDto createDto)
		{
			var command = new CreateProductReviewCommand { CreateDto = createDto };
			var response = await _mediator.Send(command);
			return Ok(response);

		}

		// PUT api/<BillController>/5
		[HttpPut("{id}")]
		public async Task<ActionResult> Put(int id, [FromBody] ProductReviewUpdateDto updateDto)
		{
			var command = new UpdateProductReviewCommand { UpdateDto = updateDto };
			await _mediator.Send(command);
			return NoContent();
		}

		// DELETE api/<BillController>/5
		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var command = new DeleteProductReviewCommand { Id = id };
			await _mediator.Send(command);
			return NoContent();
		}
	}
}
