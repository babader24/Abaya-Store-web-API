using FluentValidation;

namespace Abaya_Store.Application.DTOs.ProductReview.Validator
{
	public class ProductReviewUpdateDtoValidator : AbstractValidator<ProductReviewUpdateDto>
	{
		public ProductReviewUpdateDtoValidator()
		{
			Include(new IProductReviewDtoValidator());

			RuleFor(r => r.Id)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");
		}
	}
}
