using FluentValidation;

namespace Abaya_Store.Application.DTOs.PaymentTransaction.Validator
{
	public class PaymentTransactionUpdateDtoValidator : AbstractValidator<PaymentTransactionUpdateDto>
	{
		public PaymentTransactionUpdateDtoValidator()
		{
			Include(new IPaymentTransactionDtoValidator());

			RuleFor(p => p.Id)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");
		}
	}
}
