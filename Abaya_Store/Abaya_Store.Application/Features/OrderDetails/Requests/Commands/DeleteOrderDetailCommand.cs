using MediatR;

namespace Abaya_Store.Application.Features.OrderDetails.Requests.Commands
{
	public class DeleteOrderDetailCommand : IRequest<Unit>
	{
		public int Id { get; set; }
	}
}
