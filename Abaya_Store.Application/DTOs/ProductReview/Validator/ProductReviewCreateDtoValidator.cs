using FluentValidation;

namespace Abaya_Store.Application.DTOs.ProductReview.Validator
{
	public class ProductReviewCreateDtoValidator : AbstractValidator<ProductReviewCreateDto>
	{
		public ProductReviewCreateDtoValidator()
		{
			Include(new IProductReviewDtoValidator());
		}
	}
}
