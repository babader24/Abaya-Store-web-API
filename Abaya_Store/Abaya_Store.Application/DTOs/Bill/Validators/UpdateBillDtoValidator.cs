using FluentValidation;

namespace Abaya_Store.Application.DTOs.Bill.Validators
{
	public class UpdateBillDtoValidator : AbstractValidator<UpdateBillDto>
	{
		public UpdateBillDtoValidator()
		{
			Include(new IBillDtoValidator());

			RuleFor(b => b.BillDate)
				.LessThanOrEqualTo(DateTime.Now)
				.WithMessage("{PropertyName} cannot be in the future.");
		}
	}
}
