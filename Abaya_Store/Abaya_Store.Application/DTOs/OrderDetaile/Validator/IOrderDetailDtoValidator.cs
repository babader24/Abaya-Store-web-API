using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.OrderDetaile.Validator
{
	public class IOrderDetailDtoValidator : AbstractValidator<IOrderDetailDto>
	{
		public IOrderDetailDtoValidator()
		{
			RuleFor(d => d.ProductId)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");

			RuleFor(d => d.Quantity)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");

			RuleFor(d => d.UnitPrice)
				.GreaterThanOrEqualTo(0).WithMessage("{PropertyName} must be non-negative.");

			RuleFor(d => d.Amount)
				.GreaterThanOrEqualTo(0).WithMessage("{PropertyName} must be non-negative.")
				.Must((dto, amount) => amount == dto.UnitPrice * dto.Quantity)
				.WithMessage("Amount must equal UnitPrice multiplied by Quantity");

			RuleFor(d => d.BillId)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");
		}
	}
}
