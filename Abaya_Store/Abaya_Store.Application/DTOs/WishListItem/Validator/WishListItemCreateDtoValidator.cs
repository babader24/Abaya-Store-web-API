using FluentValidation;

namespace Abaya_Store.Application.DTOs.WishListItem.Validator
{
	public class WishListItemCreateDtoValidator : AbstractValidator<WishListItemCreateDto>
	{
		public WishListItemCreateDtoValidator()
		{
			Include(new IWishListItemDtoValidator());
		}
	}
}
