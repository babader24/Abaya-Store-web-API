using MediatR;

namespace Abaya_Store.Application.Features.ShippingInfos.Requests.Commands
{
	public class DeleteShippingInfoCommand : IRequest<Unit>
	{
		public int Id { get; set; }
	}
}
