using FluentValidation;

namespace Abaya_Store.Application.DTOs.OfferProduct.Validator
{
	public class OfferProductUpdateDtoValidator : AbstractValidator<OfferProductUpdateDto>
	{
		public OfferProductUpdateDtoValidator()
		{
			Include(new IOfferProductDtoValidator());

			RuleFor(op => op.Id)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");
		}
	}
}
