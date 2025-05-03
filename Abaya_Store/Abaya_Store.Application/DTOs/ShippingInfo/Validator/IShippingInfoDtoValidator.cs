using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.ShippingInfo.Validator
{
	public class IShippingInfoDtoValidator : AbstractValidator<IShippingInfoDto>
	{
		public IShippingInfoDtoValidator()
		{
			RuleFor(s => s.City)
				.NotNull()
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.MaximumLength(50).WithMessage("{PropertyName} must not exceed {MaxLength} characters.");

			RuleFor(s => s.Address)
				.NotNull()
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.MaximumLength(200).WithMessage("{PropertyName} must not exceed {MaxLength} characters.");

			RuleFor(s => s.PostalCode)
				.NotNull()
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.MaximumLength(20).WithMessage("{PropertyName} must not exceed {MaxLength} characters.");

			RuleFor(s => s.DeliveryStatus)
				.InclusiveBetween((byte)0, (byte)3).WithMessage("{PropertyName} must be between 0 and 3.");
		}
	}

}
