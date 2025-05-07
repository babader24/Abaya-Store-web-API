using Abaya_Store.Application.DTOs.ShippingInfo.Validator;
using Abaya_Store.Application.Features.ShippingInfos.Requests.Commands;
using Abaya_Store.Application.Contracts.Persistence;
using Abaya_Store.Application.Responses;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.ShippingInfos.Handlers.Commands
{
	public class CreateShippingInfoCommandHandler : IRequestHandler<CreateShippingInfoCommand, BaseCommandRespons>
	{
		private readonly IShippingInfoRepository _shippingInfoRepository;
		private readonly IMapper _mapper;

		public CreateShippingInfoCommandHandler(IShippingInfoRepository shippingInfoRepository, IMapper mapper)
		{
			_shippingInfoRepository = shippingInfoRepository;
			_mapper = mapper;
		}

		public async Task<BaseCommandRespons> Handle(CreateShippingInfoCommand request, CancellationToken cancellationToken)
		{
			var response = new BaseCommandRespons();
			var createValidator = new ShippingInfoCreateDtoValidator();
			var createResult = createValidator.Validate(request.createDto);

			if (createResult.IsValid == false)
				response = response.Failure(createResult.Errors.Select(e => e.ErrorMessage).ToList());

			var shippingInfo = _mapper.Map<ShippingInfo>(request.createDto);
			shippingInfo = await _shippingInfoRepository.AddAsync(shippingInfo);

			response = response.Success(shippingInfo.Id);
			return response;
		}
	}
}
