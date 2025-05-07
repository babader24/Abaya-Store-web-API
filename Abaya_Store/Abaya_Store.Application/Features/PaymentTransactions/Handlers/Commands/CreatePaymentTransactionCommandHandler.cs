using Abaya_Store.Application.DTOs.PaymentTransaction.Validator;
using Abaya_Store.Application.Features.PaymentTransactions.Requests.Commands;
using Abaya_Store.Application.Contracts.Persistence;
using Abaya_Store.Application.Responses;
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
	public class CreatePaymentTransactionCommandHandler : IRequestHandler<CreatePaymentTransactionCommand, BaseCommandRespons>
	{
		private readonly IPaymentTransactionRepository _paymentTransactionRepository;
		private readonly IMapper _mapper;

		public CreatePaymentTransactionCommandHandler(IPaymentTransactionRepository paymentTransactionRepository, IMapper mapper)
		{
			_paymentTransactionRepository = paymentTransactionRepository;
			_mapper = mapper;
		}

		public async Task<BaseCommandRespons> Handle(CreatePaymentTransactionCommand request, CancellationToken cancellationToken)
		{
			var response = new BaseCommandRespons();
			var createValidator = new PaymentTransactionCreateDtoValidator();
			var createResult = createValidator.Validate(request.createDto);

			if (createResult.IsValid == false)
				response = response.Failure(createResult.Errors.Select(e => e.ErrorMessage).ToList());

			var payment = _mapper.Map<PaymentTransaction>(request.createDto);

			payment = await _paymentTransactionRepository.AddAsync(payment);

			response = response.Success(payment.Id);
			return response;
		}
	}
}
