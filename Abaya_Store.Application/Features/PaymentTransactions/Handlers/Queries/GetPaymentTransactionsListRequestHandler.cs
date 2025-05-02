using Abaya_Store.Application.DTOs.PaymentTransaction;
using Abaya_Store.Application.Features.PaymentTransactions.Requests.Queries;
using Abaya_Store.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.PaymentTransactions.Handlers.Queries
{
	public class GetPaymentTransactionsListRequestHandler : IRequestHandler<GetPaymentTransactionsListRequest, List<PaymentTransactionListDto>>
	{
		private readonly IPaymentTransactionRepository _paymentTransactionRepository;
		private readonly IMapper _mapper;

		public GetPaymentTransactionsListRequestHandler(IPaymentTransactionRepository paymentTransactionRepository, IMapper mapper)
		{
			_paymentTransactionRepository = paymentTransactionRepository;
			_mapper = mapper;
		}

		public async Task<List<PaymentTransactionListDto>> Handle(GetPaymentTransactionsListRequest request, CancellationToken cancellationToken)
		{
			var payments = await _paymentTransactionRepository.GetAllAsync();

			return _mapper.Map<List<PaymentTransactionListDto>>(payments);
		}
	}
}
