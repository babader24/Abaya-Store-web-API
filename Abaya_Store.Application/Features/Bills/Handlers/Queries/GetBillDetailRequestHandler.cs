using Abaya_Store.Application.DTOs.Bill;
using Abaya_Store.Application.Features.Bills.Requests.Queries;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Bills.Handlers.Queries
{
	public class GetBillDetailRequestHandler : IRequestHandler<GetBillDetailRequest, BillDto>
	{
 		private readonly IBillRepository _billRepository;
		private readonly IMapper _mapper;

		public GetBillDetailRequestHandler(IBillRepository billRepository, IMapper mapper)
		{
			_billRepository = billRepository;
			_mapper = mapper;
		}
		public async Task<BillDto> Handle(GetBillDetailRequest request, CancellationToken cancellationToken)
		{
			var bill = await _billRepository.GetByIdIncludeAsync(request.Id);

			return _mapper.Map<BillDto>(bill);
		}
	}
}
