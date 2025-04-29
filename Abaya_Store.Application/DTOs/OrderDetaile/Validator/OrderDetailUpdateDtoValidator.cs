using FluentValidation;

namespace Abaya_Store.Application.DTOs.OrderDetaile.Validator
{
	public class OrderDetailUpdateDtoValidator : AbstractValidator<OrderDetailUpdateDto>
	{
		public OrderDetailUpdateDtoValidator()
		{
			Include(new IOrderDetailDtoValidator());

			RuleFor(d => d.Id)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");
		}
	}
}
