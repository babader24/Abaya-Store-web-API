using FluentValidation;

namespace Abaya_Store.Application.DTOs.User.Validator
{
	public class UserUpdateDtoValidator : AbstractValidator<UserUpdateDto>
	{
		public UserUpdateDtoValidator()
		{
			Include(new IUserDtoValidator());

			RuleFor(u => u.Id)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");
		}
	}

}
