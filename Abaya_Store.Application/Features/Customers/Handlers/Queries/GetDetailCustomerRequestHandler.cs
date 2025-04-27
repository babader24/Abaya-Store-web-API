using Abaya_Store.Application.DTOs.Customer;
using Abaya_Store.Application.Features.Customers.Requests.Queries;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Customers.Handlers.Queries
{
	public class GetDetailCustomerRequestHandler : IRequestHandler<GetDetailCustomerRequest, CustomerDto>
	{
		private readonly ICustomerRepository _customerRepository;
		private readonly IMapper _mapper;

		public GetDetailCustomerRequestHandler(ICustomerRepository customerRepository, IMapper mapper)
		{
			_customerRepository = customerRepository;
			_mapper = mapper;
		}
		public async Task<CustomerDto> Handle(GetDetailCustomerRequest request, CancellationToken cancellationToken)
		{
			var customer = await _customerRepository.GetByIdIncludeAsync(request.Id);

			return _mapper.Map<CustomerDto>(customer);
		}
	}
}
