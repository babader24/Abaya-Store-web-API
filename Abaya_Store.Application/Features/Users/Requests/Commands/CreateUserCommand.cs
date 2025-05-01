using Abaya_Store.Application.DTOs.User;
using Abaya_Store.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Users.Requests.Commands
{
	public class CreateUserCommand : IRequest<BaseCommandRespons>
	{
		public UserCreateDto CreateDto { get; set; }
	}
}
