using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.PaymentTransaction.Validator
{
	public class IPaymentTransactionDtoValidator : AbstractValidator<IPaymentTransactionDto>
	{
		public IPaymentTransactionDtoValidator()
		{
			RuleFor(p => p.BillId)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");

			RuleFor(p => p.PaymentGateway)
				.NotNull().NotEmpty().WithMessage("{PropertyName} is required.")
				.MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

			RuleFor(p => p.TransactionId)
				.NotNull().NotEmpty().WithMessage("{PropertyName} is required.")
				.MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters.");

			RuleFor(p => p.Amount)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");

			RuleFor(p => p.ResponseMessage)
				.MaximumLength(500).When(p => !string.IsNullOrEmpty(p.ResponseMessage))
				.WithMessage("{PropertyName} must not exceed 500 characters.");
		}
	}
}
