using FluentValidation;

namespace Abaya_Store.Application.DTOs.Customer.Validator
{
	public class CustomerUpdateDtoValidator : AbstractValidator<CustomerUpdateDto>
	{
		public CustomerUpdateDtoValidator()
		{
			Include(new ICustomerDtoValidator());

			RuleFor(c => c.Id)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");
		}
	}
}
