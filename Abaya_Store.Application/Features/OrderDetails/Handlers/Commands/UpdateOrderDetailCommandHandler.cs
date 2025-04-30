using Abaya_Store.Application.DTOs.OrderDetaile.Validator;
using Abaya_Store.Application.Exceptions;
using Abaya_Store.Application.Features.OrderDetails.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.OrderDetails.Handlers.Commands
{
	public class UpdateOrderDetailCommandHandler : IRequestHandler<UpdateOrderDetailCommand>
	{
		private readonly IOrderDetaileRepository _orderDetaileRepository;
		private readonly IMapper _mapper;

		public UpdateOrderDetailCommandHandler(IOrderDetaileRepository orderDetaileRepository, IMapper mapper)
		{
			_orderDetaileRepository = orderDetaileRepository;
			_mapper = mapper;
		}
		public async Task<Unit> Handle(UpdateOrderDetailCommand request, CancellationToken cancellationToken)
		{
			var updateValidator = new OrderDetailUpdateDtoValidator();
			var updateResult = updateValidator.Validate(request.updateDto);

			if (updateResult.IsValid == false)
				throw new ValidationException(updateResult);

			var orderDetail = await _orderDetaileRepository.GetByIdAsync(request.updateDto.Id);

			if( orderDetail != null)
			{
				_mapper.Map(request.updateDto, orderDetail);

				await _orderDetaileRepository.UpdateAsync(orderDetail);
			}
			return Unit.Value;
		}
	}
}
