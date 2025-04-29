using FluentValidation;

namespace Abaya_Store.Application.DTOs.Offer.Validator
{
	public class OfferCreateDtoValidator : AbstractValidator<OfferCreateDto>
	{
		public OfferCreateDtoValidator()
		{
			Include(new IOfferDtoValidator());
		}
	}

}
