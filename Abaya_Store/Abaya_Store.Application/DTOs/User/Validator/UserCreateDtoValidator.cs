using FluentValidation;

namespace Abaya_Store.Application.DTOs.User.Validator
{
	public class UserCreateDtoValidator : AbstractValidator<UserCreateDto>
	{
		public UserCreateDtoValidator()
		{
			Include(new IUserDtoValidator());
		}
	}

}
