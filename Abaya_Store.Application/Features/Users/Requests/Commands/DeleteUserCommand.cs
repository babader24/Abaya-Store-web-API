using MediatR;

namespace Abaya_Store.Application.Features.Users.Requests.Commands
{
	public class DeleteUserCommand : IRequest<Unit>
	{
		public int Id { get; set; }
	}
}
