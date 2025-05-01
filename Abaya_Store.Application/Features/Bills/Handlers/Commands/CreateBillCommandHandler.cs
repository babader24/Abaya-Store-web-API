using Abaya_Store.Application.DTOs.Bill.Validators;
using Abaya_Store.Application.Features.Bills.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using Abaya_Store.Application.Responses;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Bills.Handlers.Commands
{
	class CreateBillCommandHandler : IRequestHandler<CreateBillCommand, BaseCommandRespons>
	{
		private readonly IBillRepository _billRepository;
		private readonly IMapper _mapper;

		public CreateBillCommandHandler(IBillRepository billRepository, IMapper mapper)
		{
			_billRepository = billRepository;
			_mapper = mapper;
		}
		public async Task<BaseCommandRespons> Handle(CreateBillCommand request, CancellationToken cancellationToken)
		{
			var response = new BaseCommandRespons();
			var validator = new CreateBillDtoValidator();

			var validatorResult = validator.Validate(request.BillDto);

			if (validatorResult.IsValid == false)
				response.Failure(validatorResult.Errors.Select(e => e.ErrorMessage).ToList());

			var bill = _mapper.Map<Bill>(request.BillDto);
			bill = await _billRepository.AddAsync(bill);

			response.Success(bill.Id);
			return response;
		}
	}
}
