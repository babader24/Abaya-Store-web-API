using FluentValidation;

namespace Abaya_Store.Application.DTOs.ShippingInfo.Validator
{
	public class ShippingInfoUpdateDtoValidator : AbstractValidator<ShippingInfoUpdateDto>
	{
		public ShippingInfoUpdateDtoValidator()
		{
			Include(new IShippingInfoDtoValidator());

			RuleFor(s => s.Id)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");
		}
	}

}
