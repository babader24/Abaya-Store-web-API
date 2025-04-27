using Abaya_Store.Application.DTOs.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Users.Requests.Commands
{
	public class CreateUserCommand : IRequest<int>
	{
		public UserCreateDto CreateDto { get; set; }
	}
}
