using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.WishList.Validator
{
    public class WhshListCreateDtoValidator : AbstractValidator<WishListCreateDto>
    {
		public WhshListCreateDtoValidator()
		{
			RuleFor(r => r.CustomerId)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");
		}
	}
}
