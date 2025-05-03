using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.Bill.Validators
{
    public class IBillDtoValidator : AbstractValidator<IBillDto>
    {
		public IBillDtoValidator()
		{
			RuleFor(b => b.BillNumber)
				.NotNull()
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.MaximumLength(10).WithMessage("{PropertyName} must not exceed {MaxLength} characters.");

			RuleFor(b => b.CustomerId)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");

			RuleFor(b => b.Total)
				.GreaterThanOrEqualTo(0).WithMessage("{PropertyName} must be non-negative.");

			RuleFor(b => b.PaymentStatus)
				.InclusiveBetween((byte)0, (byte)2).WithMessage("{PropertyName} must be between 0 and 2.");

		}
	}
}
