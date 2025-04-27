using Abaya_Store.Application.DTOs.Offer;
using Abaya_Store.Application.Features.Offers.Requests.Queries;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Offers.Handlers.Queries
{
	public class GetOffersListRequestHabdler : IRequestHandler<GetOffersListRequest, List<OfferListDto>>
	{
		private readonly IOfferRepository _offerRepository;
		private readonly IMapper _mapper;

		public GetOffersListRequestHabdler(IOfferRepository offerRepository , IMapper mapper)
		{
			_offerRepository = offerRepository;
			_mapper = mapper;
		}
		public async Task<List<OfferListDto>> Handle(GetOffersListRequest request, CancellationToken cancellationToken)
		{
			var offers = await _offerRepository.GetAllAsync();

			return _mapper.Map<List<OfferListDto>>(offers);
		}
	}
}
