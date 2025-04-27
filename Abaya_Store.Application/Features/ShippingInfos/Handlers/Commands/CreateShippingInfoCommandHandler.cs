using Abaya_Store.Application.Features.ShippingInfos.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
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
	public class CreateShippingInfoCommandHandler : IRequestHandler<CreateShippingInfoCommand, int>
	{
		private readonly IShippingInfoRepository _shippingInfoRepository;
		private readonly IMapper _mapper;

		public CreateShippingInfoCommandHandler(IShippingInfoRepository shippingInfoRepository, IMapper mapper)
		{
			_shippingInfoRepository = shippingInfoRepository;
			_mapper = mapper;
		}

		public async Task<int> Handle(CreateShippingInfoCommand request, CancellationToken cancellationToken)
		{
			var shippingInfo = _mapper.Map<ShippingInfo>(request.createDto);
			shippingInfo = await _shippingInfoRepository.AddAsync(shippingInfo);
			return shippingInfo.Id;
		}
	}
}
