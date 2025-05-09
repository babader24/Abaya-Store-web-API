﻿using Abaya_Store.Application.Exceptions;
using Abaya_Store.Application.Features.OrderDetails.Requests.Commands;
using Abaya_Store.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.OrderDetails.Handlers.Commands
{
	public class DeleteOrderDetailCommandHandler : IRequestHandler<DeleteOrderDetailCommand>
	{
		private readonly IOrderDetaileRepository _orderDetaileRepository;
		private readonly IMapper _mapper;

		public DeleteOrderDetailCommandHandler(IOrderDetaileRepository orderDetaileRepository, IMapper mapper)
		{
			_orderDetaileRepository = orderDetaileRepository;
			_mapper = mapper;
		}
		public async Task<Unit> Handle(DeleteOrderDetailCommand request, CancellationToken cancellationToken)
		{
			var orderDetail = await _orderDetaileRepository.GetByIdAsync(request.Id);

			if (orderDetail == null)
				throw new NotFoundException(nameof(orderDetail), request.Id);

			await _orderDetaileRepository.DeleteAsync(orderDetail);

			return Unit.Value;
		}
	}
}
