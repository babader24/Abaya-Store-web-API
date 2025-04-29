using FluentValidation;

namespace Abaya_Store.Application.DTOs.Offer.Validator
{
	public class OfferUpdateDtoValidator : AbstractValidator<OfferUpdateDto>
	{
		public OfferUpdateDtoValidator()
		{
			Include(new IOfferDtoValidator());

			RuleFor(o => o.Id)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");
		}
	}

}
