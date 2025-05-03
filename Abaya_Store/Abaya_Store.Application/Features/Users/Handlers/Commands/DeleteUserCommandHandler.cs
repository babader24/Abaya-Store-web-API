using Abaya_Store.Application.Exceptions;
using Abaya_Store.Application.Features.Users.Requests.Commands;
using Abaya_Store.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;

namespace Abaya_Store.Application.Features.Users.Handlers.Commands
{
	public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand>
	{
		private readonly IUserRepository _userRepository;
		private readonly IMapper _mapper;

		public DeleteUserCommandHandler(IUserRepository userRepository, IMapper mapper)
		{
			_userRepository = userRepository;
			_mapper = mapper;
		}

		public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
		{
			var user = await _userRepository.GetByIdAsync(request.Id);

			if (user == null)
				throw new NotFoundException(nameof(user), request.Id);


			await _userRepository.DeleteAsync(user);
			return Unit.Value;
		}
	}
}
