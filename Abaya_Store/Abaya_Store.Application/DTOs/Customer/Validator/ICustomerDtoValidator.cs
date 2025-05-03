using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.Customer.Validator
{
	public class ICustomerDtoValidator : AbstractValidator<ICustomerDto>
	{
		public ICustomerDtoValidator()
		{
			RuleFor(c => c.FirstName)
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.MaximumLength(50);

			RuleFor(c => c.LastName)
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.MaximumLength(50);

			RuleFor(c => c.Email)
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.EmailAddress().WithMessage("{PropertyName} must be a valid email.");

			RuleFor(c => c.Phone)
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.MaximumLength(20);

			RuleFor(c => c.Password)
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.MinimumLength(6).WithMessage("{PropertyName} must be at least 6 characters.");

			RuleFor(c => c.Role)
				.InclusiveBetween((byte)0, (byte)2).WithMessage("{PropertyName} must be between 0 and 2.");

			RuleFor(c => c.Status)
				.InclusiveBetween((byte)0, (byte)1).WithMessage("{PropertyName} must be 0 or 1.");
		}
	}
}
