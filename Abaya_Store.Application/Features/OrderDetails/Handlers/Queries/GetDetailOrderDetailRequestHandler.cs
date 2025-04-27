using Abaya_Store.Application.DTOs.OrderDetaile;
using Abaya_Store.Application.Features.OrderDetails.Requests.Queries;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.OrderDetails.Handlers.Queries
{
	public class GetDetailOrderDetailRequestHandler : IRequestHandler<GetDetailOrderDetailRequest, OrderDetailDto>
	{
		private readonly IOrderDetaileRepository _orderDetaileRepository;
		private readonly IMapper _mapper;

		public GetDetailOrderDetailRequestHandler(IOrderDetaileRepository orderDetaileRepository, IMapper mapper)
		{
			_orderDetaileRepository = orderDetaileRepository;
			_mapper = mapper;
		}

		public async Task<OrderDetailDto> Handle(GetDetailOrderDetailRequest request, CancellationToken cancellationToken)
		{
			var orderDetail = await _orderDetaileRepository.GetByIdIncludeAsync(request.Id);
			return _mapper.Map<OrderDetailDto>(orderDetail);
		}
	}
}
