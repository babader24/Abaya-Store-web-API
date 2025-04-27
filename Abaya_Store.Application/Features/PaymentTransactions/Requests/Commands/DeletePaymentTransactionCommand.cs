using MediatR;

namespace Abaya_Store.Application.Features.PaymentTransactions.Requests.Commands
{
	public class DeletePaymentTransactionCommand : IRequest<Unit>
	{
		public int Id { get; set; }
	}
}
