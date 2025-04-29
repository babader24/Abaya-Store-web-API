using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.Offer.Validator
{
	public class IOfferDtoValidator : AbstractValidator<IOfferDto>
	{
		public IOfferDtoValidator()
		{
			RuleFor(o => o.DiscountPercentage)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.")
				.LessThanOrEqualTo(100).WithMessage("{PropertyName} must be less than or equal to 100.");

			RuleFor(o => o.StartDate)
				.LessThan(o => o.EndDate).WithMessage("Start date must be before end date.");

			RuleFor(o => o.EndDate)
				.GreaterThan(o => o.StartDate).WithMessage("End date must be after start date.")
				.GreaterThanOrEqualTo(DateTime.Today).WithMessage("End date cannot be in the past.");
		}
	}

}
