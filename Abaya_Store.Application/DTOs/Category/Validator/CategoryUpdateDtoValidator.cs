using FluentValidation;

namespace Abaya_Store.Application.DTOs.Category.Validator
{
	public class CategoryUpdateDtoValidator : AbstractValidator<CategoryUpdateDto>
	{
		public CategoryUpdateDtoValidator()
		{
			Include(new ICategoryDtoValidator());

			RuleFor(c => c.Id)
				.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");
		}
	}
}
