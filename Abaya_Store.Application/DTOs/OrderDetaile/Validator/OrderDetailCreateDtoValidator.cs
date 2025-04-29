using FluentValidation;

namespace Abaya_Store.Application.DTOs.OrderDetaile.Validator
{
	public class OrderDetailCreateDtoValidator : AbstractValidator<OrderDetailCreateDto>
	{
		public OrderDetailCreateDtoValidator()
		{
			Include(new IOrderDetailDtoValidator());
		}
	}
}
