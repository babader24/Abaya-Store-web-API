using Abaya_Store.Application.DTOs.User;
using Abaya_Store.Application.Features.Users.Requests.Queries;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace Abaya_Store.Application.Features.Users.Handlers.Queries
{
	public class GetUserDetailRequestHandler : IRequestHandler<GetUserDetailRequest, UserDto>
	{
		private readonly IUserRepository _userRepository;
		private readonly IMapper _mapper;

		public GetUserDetailRequestHandler(IUserRepository userRepository, IMapper mapper)
		{
			_userRepository = userRepository;
			_mapper = mapper;
		}

		public async Task<UserDto> Handle(GetUserDetailRequest request, CancellationToken cancellationToken)
		{
			var user = await _userRepository.GetByIdIncludeAsync(request.Id);
			return _mapper.Map<UserDto>(user);
		}
	}
}
