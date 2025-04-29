using FluentValidation;

namespace Abaya_Store.Application.DTOs.Product.Validator
{
	public class ProductUpdateDtoValidator : AbstractValidator<ProductUpdateDto>
	{
		public ProductUpdateDtoValidator()
		{
			Include(new IProductDtoValidator());

			RuleFor(p => p.Id)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");
		}
	}
}
