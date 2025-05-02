using Abaya_Store.Application.DTOs.OrderDetaile;
using Abaya_Store.Application.Features.OrderDetails.Requests.Queries;
using Abaya_Store.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.OrderDetails.Handlers.Queries
{
	public class GetOrderDetailsListRequestHandler : IRequestHandler<GetOrderDetailsListRequest, List<OrderDetailListDto>>
	{
		private readonly IOrderDetaileRepository _orderDetaileRepository;
		private readonly IMapper _mapper;

		public GetOrderDetailsListRequestHandler(IOrderDetaileRepository orderDetaileRepository, IMapper mapper)
		{
			_orderDetaileRepository = orderDetaileRepository;
			_mapper = mapper;
		}
		public async Task<List<OrderDetailListDto>> Handle(GetOrderDetailsListRequest request, CancellationToken cancellationToken)
		{
			var OrderDetailsList = await _orderDetaileRepository.GetAllIncludingAsync();
			return _mapper.Map<List<OrderDetailListDto>>(OrderDetailsList);
		}
	}
}
