using Abaya_Store.Application.DTOs.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Users.Requests.Queries
{
	public class GetUsersListRequest : IRequest<List<UserListDto>>
	{
	}
}
