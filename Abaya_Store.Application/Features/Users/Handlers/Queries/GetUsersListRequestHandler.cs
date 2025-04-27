using Abaya_Store.Application.DTOs.User;
using Abaya_Store.Application.Features.Users.Requests.Queries;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Users.Handlers.Queries
{
	public class GetUsersListRequestHandler : IRequestHandler<GetUsersListRequest, List<UserListDto>>
	{
		private readonly IUserRepository _userRepository;
		private readonly IMapper _mapper;

		public GetUsersListRequestHandler(IUserRepository userRepository, IMapper mapper)
		{
			_userRepository = userRepository;
			_mapper = mapper;
		}

		public async Task<List<UserListDto>> Handle(GetUsersListRequest request, CancellationToken cancellationToken)
		{
			var users = await _userRepository.GetAllAsync();
			return _mapper.Map<List<UserListDto>>(users);
		}
	}
}
