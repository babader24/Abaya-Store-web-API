using Abaya_Store.Application.DTOs.Customer;
using Abaya_Store.Application.Features.Customers.Requests.Queries;
using Abaya_Store.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Customers.Handlers.Queries
{
	public class GetCustomerListRequestHandler : IRequestHandler<GetCustomerListRequest, List<CustomerListDto>>
	{
		private readonly ICustomerRepository _customerRepository;
		private readonly IMapper _mapper;

		public GetCustomerListRequestHandler(ICustomerRepository customerRepository, IMapper mapper)
		{
			_customerRepository = customerRepository;
			_mapper = mapper;
		}
		public async Task<List<CustomerListDto>> Handle(GetCustomerListRequest request, CancellationToken cancellationToken)
		{
			var customers = await _customerRepository.GetAllAsync();

			return _mapper.Map<List<CustomerListDto>>(customers);
		}
	}
}
