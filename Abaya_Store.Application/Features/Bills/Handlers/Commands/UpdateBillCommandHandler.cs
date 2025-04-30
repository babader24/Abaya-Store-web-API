using Abaya_Store.Application.DTOs.Bill.Validators;
using Abaya_Store.Application.Exceptions;
using Abaya_Store.Application.Features.Bills.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Bills.Handlers.Commands
{
	public class UpdateBillCommandHandler : IRequestHandler<UpdateBillCommand, Unit>
	{
		private readonly IBillRepository _billRepository;
		private readonly IMapper _mapper;

		public UpdateBillCommandHandler(IBillRepository billRepository, IMapper mapper)
		{
			_billRepository = billRepository;
			_mapper = mapper;
		}

		public async Task<Unit> Handle(UpdateBillCommand request, CancellationToken cancellationToken)
		{
			var validator = new UpdateBillDtoValidator();
			var validatorResult = validator.Validate(request.UpdateBillDto);

			if (validatorResult.IsValid == false)
				throw new ValidationException(validatorResult);

			var bill = await _billRepository.GetByIdAsync(request.Id);

			if (bill != null)
			{
				_mapper.Map(request.UpdateBillDto, bill);

				await _billRepository.UpdateAsync(bill);
			}
			return Unit.Value;
		}
	}
}
