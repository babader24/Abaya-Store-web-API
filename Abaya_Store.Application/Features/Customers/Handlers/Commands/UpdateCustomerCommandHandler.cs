using Abaya_Store.Application.DTOs.Customer.Validator;
using Abaya_Store.Application.Exceptions;
using Abaya_Store.Application.Features.Customers.Requests.Commands;
using Abaya_Store.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Customers.Handlers.Commands
{
	public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, Unit>
	{
		private readonly ICustomerRepository _customerRepository;
		private readonly IMapper _mapper;

		public UpdateCustomerCommandHandler(ICustomerRepository customerRepository, IMapper mapper)
		{
			_customerRepository = customerRepository;
			_mapper = mapper;
		}
		public async Task<Unit> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
		{
			var validator = new CustomerUpdateDtoValidator();
			var validatorResult = validator.Validate(request.CustomerUpdateDto);


			if (validatorResult.IsValid == false)
				throw new ValidationException(validatorResult);


			var cutomer = await _customerRepository.GetByIdAsync(request.CustomerUpdateDto.Id);

			if(cutomer != null)
			{
				_mapper.Map(request.CustomerUpdateDto, cutomer);

				await _customerRepository.UpdateAsync(cutomer);
			}
			return Unit.Value;
		}
	}
}
