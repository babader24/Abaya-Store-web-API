using FluentValidation;

namespace Abaya_Store.Application.DTOs.WishListItem.Validator
{
	public class WishListItemUpdateDtoValidator : AbstractValidator<WishListItemUpdateDto>
	{
		public WishListItemUpdateDtoValidator()
		{
			Include(new IWishListItemDtoValidator());

			RuleFor(w => w.Id)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");
		}
	}
}
