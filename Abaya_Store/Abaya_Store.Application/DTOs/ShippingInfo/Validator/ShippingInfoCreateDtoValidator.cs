using FluentValidation;

namespace Abaya_Store.Application.DTOs.ShippingInfo.Validator
{
	public class ShippingInfoCreateDtoValidator : AbstractValidator<ShippingInfoCreateDto>
	{
		public ShippingInfoCreateDtoValidator()
		{
			Include(new IShippingInfoDtoValidator());

			RuleFor(s => s.BillId)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");
		}
	}

}
