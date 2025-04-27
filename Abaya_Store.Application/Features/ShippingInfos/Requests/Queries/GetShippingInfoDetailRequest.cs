using Abaya_Store.Application.DTOs.ShippingInfo;
using MediatR;

namespace Abaya_Store.Application.Features.ShippingInfos.Requests.Queries
{
	public class GetShippingInfoDetailRequest : IRequest<ShippingInfoDto>
	{
		public int Id { get; set; }
	}

}
