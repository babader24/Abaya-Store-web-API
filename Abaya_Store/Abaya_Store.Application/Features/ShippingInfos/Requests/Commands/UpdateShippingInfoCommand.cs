using Abaya_Store.Application.DTOs.ShippingInfo;
using MediatR;

namespace Abaya_Store.Application.Features.ShippingInfos.Requests.Commands
{
	public class UpdateShippingInfoCommand : IRequest<Unit>
	{
		public ShippingInfoUpdateDto updateDto { get; set; }
	}
}
