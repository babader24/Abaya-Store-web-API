using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.Cart.Validator
{
    public class CartCreateDtoValidator : AbstractValidator<CartCreateDto>
    {
		public CartCreateDtoValidator()
		{
			RuleFor(c => c.CustomerId)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");

			RuleFor(c => c.Items)
				.NotNull().WithMessage("Items list must not be null.")
				.Must(items => items.Count > 0).WithMessage("Cart must contain at least one item.");
		}
	}
}
