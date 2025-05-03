using Abaya_Store.Application.DTOs.User;
using MediatR;

namespace Abaya_Store.Application.Features.Users.Requests.Queries
{
	public class GetUserDetailRequest : IRequest<UserDto>
	{
		public int Id { get; set; }
	}
}
