using Abaya_Store.Application.DTOs.PaymentTransaction;
using Abaya_Store.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.PaymentTransactions.Requests.Commands
{
    public class CreatePaymentTransactionCommand : IRequest<BaseCommandRespons>
    {
		public PaymentTransactionCreateDto createDto { get; set; }
	}
}
