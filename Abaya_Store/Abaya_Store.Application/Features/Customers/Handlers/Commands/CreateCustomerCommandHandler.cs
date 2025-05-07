using Abaya_Store.Application.DTOs.Customer.Validator;
using Abaya_Store.Application.Features.Customers.Requests.Commands;
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

namespace Abaya_Store.Application.Features.Customers.Handlers.Commands
{
	public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, BaseCommandRespons>
	{
		private readonly ICustomerRepository _customerRepository;
		private readonly IMapper _mapper;

		public CreateCustomerCommandHandler(ICustomerRepository customerRepository, IMapper mapper)
		{
			_customerRepository = customerRepository;
			_mapper = mapper;
		}
		public async Task<BaseCommandRespons> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
		{
			var response = new BaseCommandRespons();
			var validator = new CustomerCreateDtoValidator();
			var validatorResult = validator.Validate(request.CustomerCreateDto);

			if (validatorResult.IsValid == false)
				response = response.Failure(validatorResult.Errors.Select(e => e.ErrorMessage).ToList());

			var customer = _mapper.Map<Customer>(request.CustomerCreateDto);

			customer = await _customerRepository.AddAsync(customer);

			response = response.Success(customer.Id);
			return response;
		}
	}
}
