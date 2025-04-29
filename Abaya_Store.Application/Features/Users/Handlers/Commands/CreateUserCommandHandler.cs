using Abaya_Store.Application.DTOs.User.Validator;
using Abaya_Store.Application.Features.Users.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Users.Handlers.Commands
{
	public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
	{
		private readonly IUserRepository _userRepository;
		private readonly IMapper _mapper;

		public CreateUserCommandHandler(IUserRepository userRepository, IMapper mapper)
		{
			_userRepository = userRepository;
			_mapper = mapper;
		}

		public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
		{
			var createValidator = new UserCreateDtoValidator();
			var createResult = createValidator.Validate(request.CreateDto);

			if (!createResult.IsValid)
				throw new Exception(string.Join("\n", createResult.Errors));

			var user = _mapper.Map<User>(request.CreateDto);
			user = await _userRepository.AddAsync(user);
			return user.Id;
		}
	}
}
