using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.Category.Validator
{
	public class ICategoryDtoValidator : AbstractValidator<ICategoryDto>
	{
		public ICategoryDtoValidator()
		{
			RuleFor(c => c.Name)
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.MaximumLength(50).WithMessage("{PropertyName} must not exceed {MaxLength} characters.");
		}
	}
}
