using Abaya_Store.Application.Exceptions;
using Abaya_Store.Application.Features.PaymentTransactions.Requests.Commands;
using Abaya_Store.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.PaymentTransactions.Handlers.Commands
{
	public class DeletePaymentTransactionCommandHandler : IRequestHandler<DeletePaymentTransactionCommand>
	{
		private readonly IPaymentTransactionRepository _paymentTransactionRepository;
		private readonly IMapper _mapper;

		public DeletePaymentTransactionCommandHandler(IPaymentTransactionRepository paymentTransactionRepository, IMapper mapper)
		{
			_paymentTransactionRepository = paymentTransactionRepository;
			_mapper = mapper;
		}

		public async Task<Unit> Handle(DeletePaymentTransactionCommand request, CancellationToken cancellationToken)
		{
			var payment = await _paymentTransactionRepository.GetByIdAsync(request.Id);

			if (payment == null)
				throw new NotFoundException(nameof(payment), request.Id);

			await _paymentTransactionRepository.DeleteAsync(payment);

			return Unit.Value;
		}
	}
}
