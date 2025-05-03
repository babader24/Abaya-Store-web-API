using Abaya_Store.Application.DTOs.User;
using MediatR;

namespace Abaya_Store.Application.Features.Users.Requests.Commands
{
	public class UpdateUserCommand : IRequest<Unit>
	{
		public UserUpdateDto UpdateDto { get; set; }
	}
}
