using Abaya_Store.Application.DTOs.Product;
using MediatR;

namespace Abaya_Store.Application.Features.Products.Requests.Commands
{
	public class UpdateProductCommand : IRequest<Unit>
	{
		public ProductUpdateDto updateDto { get; set; }
	}
}
