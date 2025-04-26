using Abaya_Store.Application.DTOs.Bill;
using MediatR;

namespace Abaya_Store.Application.Features.Bills.Requests.Commands
{
	public class UpdateBillCommand : IRequest<Unit>
    {
		public int Id { get; set; }
		public UpdateBillDto UpdateBillDto { get; set; }		
	}
}
