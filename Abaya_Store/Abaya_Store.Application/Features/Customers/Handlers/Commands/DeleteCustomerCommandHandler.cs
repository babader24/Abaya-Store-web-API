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
	public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand, Unit>
	{
		private readonly ICustomerRepository _customerRepository;
		private readonly IMapper _mapper;

		public DeleteCustomerCommandHandler(ICustomerRepository customerRepository, IMapper mapper)
		{
			_customerRepository = customerRepository;
			_mapper = mapper;
		}
		public async Task<Unit> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
		{
			var customer = await _customerRepository.GetByIdAsync(request.Id);

			if (customer == null)
				throw new NotFoundException(nameof(customer), request.Id);

			await _customerRepository.DeleteAsync(customer);

			return Unit.Value;
		}
	}
}
