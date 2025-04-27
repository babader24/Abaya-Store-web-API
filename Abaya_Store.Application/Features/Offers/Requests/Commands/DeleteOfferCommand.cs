using MediatR;

namespace Abaya_Store.Application.Features.Offers.Requests.Commands
{
	public class DeleteOfferCommand : IRequest<Unit>
	{
		public int Id { get; set; }
	}
}
