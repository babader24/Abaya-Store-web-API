using Abaya_Store.Application.DTOs.User.Validator;
using Abaya_Store.Application.Exceptions;
using Abaya_Store.Application.Features.Users.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace Abaya_Store.Application.Features.Users.Handlers.Commands
{
	public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand>
	{
		private readonly IUserRepository _userRepository;
		private readonly IMapper _mapper;

		public UpdateUserCommandHandler(IUserRepository userRepository, IMapper mapper)
		{
			_userRepository = userRepository;
			_mapper = mapper;
		}

		public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
		{
			var updateValidator = new UserUpdateDtoValidator();
			var updateResult = updateValidator.Validate(request.UpdateDto);

			if (!updateResult.IsValid)
				throw new ValidationException(updateResult);

			var user = await _userRepository.GetByIdAsync(request.UpdateDto.Id);

			if (user != null)
			{
				_mapper.Map(request.UpdateDto, user);
				await _userRepository.UpdateAsync(user);
			}

			return Unit.Value;
		}
	}
}
