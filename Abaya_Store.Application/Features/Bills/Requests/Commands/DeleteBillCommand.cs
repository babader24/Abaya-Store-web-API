using MediatR;

namespace Abaya_Store.Application.Features.Bills.Requests.Commands
{
	public class DeleteBillCommand : IRequest
	{
		public int Id { get; set; }		
	}
}
