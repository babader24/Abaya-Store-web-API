using MediatR;

namespace Abaya_Store.Application.Features.OfferProducts.Requests.Commands
{
	public class DeleteOfferProductCommand : IRequest<Unit>
	{
		public int Id { get; set; }
	}
}
