using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.DTOs.Category.Validator
{
	public class CategoryCreateDtoValidator : AbstractValidator<CategoryCreateDto>
	{
		public CategoryCreateDtoValidator()
		{
			Include(new ICategoryDtoValidator());
		}
	}
}
