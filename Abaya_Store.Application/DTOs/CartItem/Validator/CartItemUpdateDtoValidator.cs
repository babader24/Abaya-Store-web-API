using FluentValidation;

namespace Abaya_Store.Application.DTOs.CartItem.Validator
{
	public class CartItemUpdateDtoValidator : AbstractValidator<CartItemUpdateDto>
	{
		public CartItemUpdateDtoValidator()
		{
			Include(new ICartItemDtoValidator());

			RuleFor(c => c.Id)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");
		}
	}
}
