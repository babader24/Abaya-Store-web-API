using Abaya_Store.Application.DTOs.PaymentTransaction.Validator;
using Abaya_Store.Application.Features.PaymentTransactions.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.PaymentTransactions.Handlers.Commands
{
	public class UpdatePaymentTransactionCommandHandler : IRequestHandler<UpdatePaymentTransactionCommand>
	{
		private readonly IPaymentTransactionRepository _paymentTransactionRepository;
		private readonly IMapper _mapper;

		public UpdatePaymentTransactionCommandHandler(IPaymentTransactionRepository paymentTransactionRepository, IMapper mapper)
		{
			_paymentTransactionRepository = paymentTransactionRepository;
			_mapper = mapper;
		}

		public async Task<Unit> Handle(UpdatePaymentTransactionCommand request, CancellationToken cancellationToken)
		{
			var updateValidator = new PaymentTransactionUpdateDtoValidator();
			var updateResult = updateValidator.Validate(request.updateDto);

			if (!updateResult.IsValid)
				throw new Exception(updateResult.ToString());

			var payment = await _paymentTransactionRepository.GetByIdAsync(request.updateDto.Id);

			if(payment != null)
			{
				_mapper.Map(request.updateDto, payment);

				await _paymentTransactionRepository.UpdateAsync(payment);
			}
			return Unit.Value;
		}
	}
}
