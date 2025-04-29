using FluentValidation;

namespace Abaya_Store.Application.DTOs.PaymentTransaction.Validator
{
	public class PaymentTransactionCreateDtoValidator : AbstractValidator<PaymentTransactionCreateDto>
	{
		public PaymentTransactionCreateDtoValidator()
		{
			Include(new IPaymentTransactionDtoValidator());
		}
	}
}
