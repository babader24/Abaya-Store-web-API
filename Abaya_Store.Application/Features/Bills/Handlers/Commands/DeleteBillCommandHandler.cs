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
	class DeleteBillCommandHandler : IRequestHandler<DeleteBillCommand>
	{
		private readonly IBillRepository _billRepository;
		private readonly IMapper _mapper;

		public DeleteBillCommandHandler(IBillRepository billRepository, IMapper mapper)
		{
			_billRepository = billRepository;
			_mapper = mapper;
		}
		public async Task<Unit> Handle(DeleteBillCommand request, CancellationToken cancellationToken)
		{
			var bill = await _billRepository.GetByIdAsync(request.Id);

			if (bill == null)
				throw new NotFoundException(nameof(bill), request.Id);

			await _billRepository.DeleteAsync(bill);

			return Unit.Value;
		}
	}
}
