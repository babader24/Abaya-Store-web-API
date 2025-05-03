using Abaya_Store.Application.DTOs.ShippingInfo;
using Abaya_Store.Application.Features.ShippingInfos.Requests.Queries;
using Abaya_Store.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;

namespace Abaya_Store.Application.Features.ShippingInfos.Handlers.Queries
{
	public class GetShippingInfoDetailRequestHandler : IRequestHandler<GetShippingInfoDetailRequest, ShippingInfoDto>
	{
		private readonly IShippingInfoRepository _shippingInfoRepository;
		private readonly IMapper _mapper;

		public GetShippingInfoDetailRequestHandler(IShippingInfoRepository shippingInfoRepository, IMapper mapper)
		{
			_shippingInfoRepository = shippingInfoRepository;
			_mapper = mapper;
		}

		public async Task<ShippingInfoDto> Handle(GetShippingInfoDetailRequest request, CancellationToken cancellationToken)
		{
			var shippingInfo = await _shippingInfoRepository.GetByIdIncludeAsync(request.Id);
			return _mapper.Map<ShippingInfoDto>(shippingInfo);
		}
	}
}
