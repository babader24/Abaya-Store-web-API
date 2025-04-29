using FluentValidation;

namespace Abaya_Store.Application.DTOs.Customer.Validator
{
	public class CustomerCreateDtoValidator : AbstractValidator<CustomerCreateDto>
	{
		public CustomerCreateDtoValidator()
		{
			Include(new ICustomerDtoValidator());
		}
	}
}
