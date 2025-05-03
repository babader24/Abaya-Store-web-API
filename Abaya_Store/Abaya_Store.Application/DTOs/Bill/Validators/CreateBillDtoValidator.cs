using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.Bill.Validators
{
    public class CreateBillDtoValidator : AbstractValidator<CreateBillDto>
	{
		public CreateBillDtoValidator()
		{
			Include(new IBillDtoValidator());
		}
	}
}
