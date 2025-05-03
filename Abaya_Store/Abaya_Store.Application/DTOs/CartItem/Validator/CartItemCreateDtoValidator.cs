using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.CartItem.Validator
{
	public class CartItemCreateDtoValidator : AbstractValidator<CartItemCreateDto>
	{
		public CartItemCreateDtoValidator()
		{
			Include(new ICartItemDtoValidator());

			RuleFor(c => c.ProductId)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");
		}
	}
}
