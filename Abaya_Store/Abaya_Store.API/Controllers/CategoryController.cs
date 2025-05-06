using Abaya_Store.Application.DTOs.Category;
using Abaya_Store.Application.Features.Categories.Requests.Commands;
using Abaya_Store.Application.Features.Categories.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Abaya_Store.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		private readonly IMediator _mediator;

		public CategoryController(IMediator mediator)
		{
			_mediator = mediator;
		}
		// GET: api/<BillController>
		[HttpGet]
		public async Task<ActionResult<List<CategoryListDto>>> Get()
		{
			var category = await _mediator.Send(new GetCategoryListRequest());
			return Ok(category);
		}

		// GET api/<BillController>/5
		[HttpGet("{id}")]
		public async Task<ActionResult<CategoryDto>> Get(int id)
		{
			var category = await _mediator.Send(new GetCategoryDetailRequest { Id = id });
			return Ok(category);
		}

		// POST api/<BillController>
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] CategoryCreateDto categoryCreateDto)
		{
			var command = new CreateCategoryCommand { categoryCreateDto = categoryCreateDto };
			var response = await _mediator.Send(command);
			return Ok(response);

		}

		// PUT api/<BillController>/5
		[HttpPut("{id}")]
		public async Task<ActionResult> Put(int id, [FromBody] CategoryUpdateDto categoryUpdateDto )
		{
			var command = new UpdateCategoryCommand { categoryUpdateDto  = categoryUpdateDto };
			await _mediator.Send(command);
			return NoContent();
		}

		// DELETE api/<BillController>/5
		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var command = new DeleteCategoryCommand { Id = id };
			await _mediator.Send(command);
			return NoContent();
		}
	}
}
