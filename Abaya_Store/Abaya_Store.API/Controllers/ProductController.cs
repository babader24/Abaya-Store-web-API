using Abaya_Store.Application.DTOs.Product;
using Abaya_Store.Application.Features.Products.Requests.Commands;
using Abaya_Store.Application.Features.Products.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Abaya_Store.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IMediator _mediator;

		public ProductController(IMediator mediator)
		{
			_mediator = mediator;
		}
		// GET: api/<BillController>
		[HttpGet]
		public async Task<ActionResult<List<ProductListDto>>> Get()
		{
			var product = await _mediator.Send(new GetProductsListRequest());
			return Ok(product);
		}

		// GET api/<BillController>/5
		[HttpGet("{id}")]
		public async Task<ActionResult<ProductDto>> Get(int id)
		{
			var product = await _mediator.Send(new GetProductDetailRequest { Id = id });
			return Ok(product);
		}

		// POST api/<BillController>
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] ProductCreateDto createDto)
		{
			var command = new CreateProductCommand { createDto = createDto };
			var response = await _mediator.Send(command);
			return Ok(response);

		}

		// PUT api/<BillController>/5
		[HttpPut("{id}")]
		public async Task<ActionResult> Put(int id, [FromBody] ProductUpdateDto updateDto)
		{
			var command = new UpdateProductCommand { updateDto = updateDto };
			await _mediator.Send(command);
			return NoContent();
		}

		// DELETE api/<BillController>/5
		[HttpDelete("{id}")]	
		public async Task<ActionResult> Delete(int id)
		{
			var command = new DeleteProductCommand { Id = id };
			await _mediator.Send(command);
			return NoContent();
		}	
	}
}
