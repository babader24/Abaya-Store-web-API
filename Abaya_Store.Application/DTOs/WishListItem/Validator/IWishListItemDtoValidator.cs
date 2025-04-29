using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.WishListItem.Validator
{
	public class IWishListItemDtoValidator : AbstractValidator<IWishListItemDto>
	{
		public IWishListItemDtoValidator()
		{
			RuleFor(w => w.ProductId)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");
		}
	}
}
