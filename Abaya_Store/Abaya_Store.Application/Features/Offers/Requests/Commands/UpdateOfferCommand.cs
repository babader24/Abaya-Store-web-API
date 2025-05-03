using Abaya_Store.Application.DTOs.Offer;
using MediatR;

namespace Abaya_Store.Application.Features.Offers.Requests.Commands
{
	public class UpdateOfferCommand : IRequest<Unit>
	{
		public OfferUpdateDto updateDto { get; set; }
	}
}
