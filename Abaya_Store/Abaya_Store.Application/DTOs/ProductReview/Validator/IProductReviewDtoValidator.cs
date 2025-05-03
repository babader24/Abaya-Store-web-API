using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.ProductReview.Validator
{
	public class IProductReviewDtoValidator : AbstractValidator<IProductReviewDto>
	{
		public IProductReviewDtoValidator()
		{
			RuleFor(r => r.ProductId)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");

			RuleFor(r => r.CustomerId)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");

			RuleFor(r => r.Rating)
				.InclusiveBetween(1, 5).WithMessage("{PropertyName} must be between 1 and 5.");

			RuleFor(r => r.Comment)
				.MaximumLength(500).WithMessage("{PropertyName} must not exceed {MaxLength} characters.");
		}
	}
}
