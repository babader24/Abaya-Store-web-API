using Abaya_Store.Application.DTOs.PaymentTransaction;
using Abaya_Store.Application.Features.PaymentTransactions.Requests.Queries;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.PaymentTransactions.Handlers.Queries
{
	public class GetPaymentTransactionDetailHandler : IRequestHandler<GetPaymentTransactionDetail, PaymentTransactionDto>
	{
		private readonly IPaymentTransactionRepository _paymentTransactionRepository;
		private readonly IMapper _mapper;

		public GetPaymentTransactionDetailHandler(IPaymentTransactionRepository paymentTransactionRepository, IMapper mapper)
		{
			_paymentTransactionRepository = paymentTransactionRepository;
			_mapper = mapper;
		}
		public async Task<PaymentTransactionDto> Handle(GetPaymentTransactionDetail request, CancellationToken cancellationToken)
		{
			var payment = await _paymentTransactionRepository.GetByIdAsync(request.Id);
			return _mapper.Map<PaymentTransactionDto>(payment);
		}
	}
}
