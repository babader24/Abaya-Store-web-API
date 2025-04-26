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
	public class GetBillListRequestHandler : IRequestHandler<GetBillListRequest, List<BillDto>>
	{
		private readonly IBillRepository _billRepository;
		private readonly IMapper _mapper;

		public GetBillListRequestHandler(IBillRepository billRepository, IMapper mapper)
		{
			_billRepository = billRepository;
			_mapper = mapper;
		}
		public async Task<List<BillDto>> Handle(GetBillListRequest request, CancellationToken cancellationToken)
		{
			var bills = await _billRepository.GetAllIncludingAsync();

			return _mapper.Map<List<BillDto>>(bills);
		}
	}
}
