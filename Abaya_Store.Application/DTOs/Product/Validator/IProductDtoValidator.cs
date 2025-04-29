using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.Product.Validator
{
	public class IProductDtoValidator : AbstractValidator<IProductDto>
	{
		public IProductDtoValidator()
		{
			RuleFor(p => p.Name)
				.NotNull()
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.MaximumLength(100).WithMessage("{PropertyName} must not exceed {MaxLength} characters.");

			RuleFor(p => p.Image)
				.NotNull()
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.MaximumLength(255).WithMessage("{PropertyName} must not exceed {MaxLength} characters.");

			RuleFor(p => p.UnitPrice)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");

			RuleFor(p => p.Description)
				.MaximumLength(500).WithMessage("{PropertyName} must not exceed {MaxLength} characters.");

			RuleFor(p => p.CategoryId)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");

			RuleFor(p => p.Size)
				.NotNull()
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.MaximumLength(20).WithMessage("{PropertyName} must not exceed {MaxLength} characters.");

			RuleFor(p => p.QuantityAvailable)
				.GreaterThanOrEqualTo(0).WithMessage("{PropertyName} must be non-negative.");

			RuleFor(p => p.OfferId)
				.GreaterThan(0).When(p => p.OfferId.HasValue)
				.WithMessage("{PropertyName} must be greater than 0 when specified.");
		}
	}
}
