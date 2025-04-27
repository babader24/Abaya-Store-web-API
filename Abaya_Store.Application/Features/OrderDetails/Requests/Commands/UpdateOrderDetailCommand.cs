using Abaya_Store.Application.DTOs.OrderDetaile;
using MediatR;

namespace Abaya_Store.Application.Features.OrderDetails.Requests.Commands
{
	public class UpdateOrderDetailCommand : IRequest<Unit>
	{
		public OrderDetailUpdateDto updateDto  { get; set; }
	}
}
