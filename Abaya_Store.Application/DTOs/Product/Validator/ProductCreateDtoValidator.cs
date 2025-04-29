using FluentValidation;

namespace Abaya_Store.Application.DTOs.Product.Validator
{
	public class ProductCreateDtoValidator : AbstractValidator<ProductCreateDto>
	{
		public ProductCreateDtoValidator()
		{
			Include(new IProductDtoValidator());
		}
	}
}
