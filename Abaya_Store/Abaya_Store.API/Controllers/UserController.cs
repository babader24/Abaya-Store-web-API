using Abaya_Store.Application.DTOs.User;
using Abaya_Store.Application.Features.Users.Requests.Commands;
using Abaya_Store.Application.Features.Users.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Abaya_Store.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IMediator _mediator;

		public UserController(IMediator mediator)
		{
			_mediator = mediator;
		}
		// GET: api/<BillController>
		[HttpGet]
		public async Task<ActionResult<List<UserListDto>>> Get()
		{
			var user = await _mediator.Send(new GetUsersListRequest());
			return Ok(user);
		}

		// GET api/<BillController>/5
		[HttpGet("{id}")]
		public async Task<ActionResult<UserDto>> Get(int id)
		{
			var user = await _mediator.Send(new GetUserDetailRequest { Id = id });
			return Ok(user);
		}

		// POST api/<BillController>
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] UserCreateDto createDto)
		{
			var command = new CreateUserCommand { CreateDto = createDto };
			var response = await _mediator.Send(command);
			return Ok(response);

		}

		// PUT api/<BillController>/5
		[HttpPut("{id}")]
		public async Task<ActionResult> Put(int id, [FromBody] UserUpdateDto updateDto)
		{
			var command = new UpdateUserCommand { UpdateDto = updateDto };
			await _mediator.Send(command);
			return NoContent();
		}

		// DELETE api/<BillController>/5
		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var command = new DeleteUserCommand { Id = id };
			await _mediator.Send(command);
			return NoContent();
		}
	}
}
