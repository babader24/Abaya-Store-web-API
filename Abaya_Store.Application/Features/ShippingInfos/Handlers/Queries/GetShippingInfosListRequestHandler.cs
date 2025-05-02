using Abaya_Store.Application.DTOs.ShippingInfo;
using Abaya_Store.Application.Features.ShippingInfos.Requests.Queries;
using Abaya_Store.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.ShippingInfos.Handlers.Queries
{
	public class GetShippingInfosListRequestHandler : IRequestHandler<GetShippingInfosListRequest, List<ShippingInfoListDto>>
	{
		private readonly IShippingInfoRepository _shippingInfoRepository;
		private readonly IMapper _mapper;

		public GetShippingInfosListRequestHandler(IShippingInfoRepository shippingInfoRepository, IMapper mapper)
		{
			_shippingInfoRepository = shippingInfoRepository;
			_mapper = mapper;
		}

		public async Task<List<ShippingInfoListDto>> Handle(GetShippingInfosListRequest request, CancellationToken cancellationToken)
		{
			var shippingInfos = await _shippingInfoRepository.GetAllAsync();
			return _mapper.Map<List<ShippingInfoListDto>>(shippingInfos);
		}
	}
}
