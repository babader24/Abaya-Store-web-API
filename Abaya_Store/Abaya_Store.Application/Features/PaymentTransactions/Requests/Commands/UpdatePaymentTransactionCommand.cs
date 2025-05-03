using Abaya_Store.Application.DTOs.PaymentTransaction;
using MediatR;

namespace Abaya_Store.Application.Features.PaymentTransactions.Requests.Commands
{
	public class UpdatePaymentTransactionCommand : IRequest<Unit>
	{
		public PaymentTransactionUpdateDto updateDto { get; set; }
	}
}
