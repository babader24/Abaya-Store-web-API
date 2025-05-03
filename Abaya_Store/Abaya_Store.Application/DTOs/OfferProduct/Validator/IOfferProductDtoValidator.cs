using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.OfferProduct.Validator
{
	public class IOfferProductDtoValidator : AbstractValidator<IOfferProductDto>
	{
		public IOfferProductDtoValidator()
		{
			RuleFor(op => op.OfferId)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");

			RuleFor(op => op.ProductId)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");
		}
	}
}
