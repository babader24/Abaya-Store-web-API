using FluentValidation;

namespace Abaya_Store.Application.DTOs.OfferProduct.Validator
{
	public class OfferProductCreateDtoValidator : AbstractValidator<OfferProductCreateDto>
	{
		public OfferProductCreateDtoValidator()
		{
			Include(new IOfferProductDtoValidator());
		}
	}
}
