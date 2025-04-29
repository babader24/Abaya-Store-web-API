using Abaya_Store.Application.DTOs.PaymentTransaction.Validator;
using Abaya_Store.Application.Features.PaymentTransactions.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.PaymentTransactions.Handlers.Commands
{
	public class CreatePaymentTransactionCommandHandler : IRequestHandler<CreatePaymentTransactionCommand, int>
	{
		private readonly IPaymentTransactionRepository _paymentTransactionRepository;
		private readonly IMapper _mapper;

		public CreatePaymentTransactionCommandHandler(IPaymentTransactionRepository paymentTransactionRepository, IMapper mapper)
		{
			_paymentTransactionRepository = paymentTransactionRepository;
			_mapper = mapper;
		}

		public async Task<int> Handle(CreatePaymentTransactionCommand request, CancellationToken cancellationToken)
		{
			var createValidator = new PaymentTransactionCreateDtoValidator();
			var createResult = createValidator.Validate(request.createDto);

			if (!createResult.IsValid)
				throw new Exception(createResult.ToString());

			var payment = _mapper.Map<PaymentTransaction>(request.createDto);

			payment = await _paymentTransactionRepository.AddAsync(payment);

			return payment.Id;
		}
	}
}
