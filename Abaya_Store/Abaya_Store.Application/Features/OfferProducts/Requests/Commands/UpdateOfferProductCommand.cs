using Abaya_Store.Application.DTOs.OfferProduct;
using MediatR;

namespace Abaya_Store.Application.Features.OfferProducts.Requests.Commands
{
	public class UpdateOfferProductCommand : IRequest<Unit>
	{
		public OfferProductUpdateDto updateDto { get; set; }

	}
}
