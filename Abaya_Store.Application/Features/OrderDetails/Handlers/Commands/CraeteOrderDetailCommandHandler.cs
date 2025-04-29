using Abaya_Store.Application.DTOs.OrderDetaile.Validator;
using Abaya_Store.Application.Features.OrderDetails.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.OrderDetails.Handlers.Commands
{
	public class CraeteOrderDetailCommandHandler : IRequestHandler<CraeteOrderDetailCommand, int>
	{
		private readonly IOrderDetaileRepository _orderDetaileRepository;
		private readonly IMapper _mapper;

		public CraeteOrderDetailCommandHandler(IOrderDetaileRepository orderDetaileRepository, IMapper mapper)
		{
			_orderDetaileRepository = orderDetaileRepository;
			_mapper = mapper;
		}
		public async Task<int> Handle(CraeteOrderDetailCommand request, CancellationToken cancellationToken)
		{
			var createValidator = new OrderDetailCreateDtoValidator();
			var createResult = createValidator.Validate(request.createDto);

			if (!createResult.IsValid)
				throw new Exception(createResult.ToString());

			var orderDetail = _mapper.Map<OrderDetaile>(request.createDto);

			orderDetail = await _orderDetaileRepository.AddAsync(orderDetail);

			return orderDetail.Id;
		}
	}
}
