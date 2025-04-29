using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.User.Validator
{
	public class IUserDtoValidator : AbstractValidator<IUserDto>
	{
		public IUserDtoValidator()
		{
			RuleFor(u => u.UserName)
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.Length(4, 20).WithMessage("{PropertyName} must be between {MinLength} and {MaxLength} characters.");

			RuleFor(u => u.FirstName)
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.MaximumLength(50).WithMessage("{PropertyName} must not exceed {MaxLength} characters.");

			RuleFor(u => u.LastName)
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.MaximumLength(50).WithMessage("{PropertyName} must not exceed {MaxLength} characters.");

			RuleFor(u => u.Email)
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.EmailAddress().WithMessage("Invalid {PropertyName} format.")
				.MaximumLength(100).WithMessage("{PropertyName} must not exceed {MaxLength} characters.");

			RuleFor(u => u.Phone)
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.Matches(@"^[0-9]+$").WithMessage("{PropertyName} must contain only numbers.")
				.Length(8, 15).WithMessage("{PropertyName} must be between {MinLength} and {MaxLength} digits.");

			RuleFor(u => u.Address)
				.MaximumLength(200).When(u => !string.IsNullOrEmpty(u.Address))
				.WithMessage("{PropertyName} must not exceed {MaxLength} characters.");

			RuleFor(u => u.Image)
				.MaximumLength(255).When(u => !string.IsNullOrEmpty(u.Image))
				.WithMessage("{PropertyName} must not exceed {MaxLength} characters.");

			RuleFor(u => u.Password)
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.MinimumLength(6).WithMessage("{PropertyName} must be at least {MinLength} characters.");

			RuleFor(u => u.Role)
				.InclusiveBetween((byte)1, (byte)3).WithMessage("{PropertyName} must be between 1 and 3.");

			RuleFor(u => u.Status)
				.InclusiveBetween((byte)0, (byte)2).WithMessage("{PropertyName} must be between 0 and 2.");

			RuleFor(u => u.Position)
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.MaximumLength(50).WithMessage("{PropertyName} must not exceed {MaxLength} characters.");

			RuleFor(u => u.Permissions)
				.InclusiveBetween((byte)0, (byte)15).WithMessage("{PropertyName} must be between 0 and 15.");
		}
	}

}
