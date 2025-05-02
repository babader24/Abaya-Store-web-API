using Abaya_Store.Application.DTOs.Offer;
using Abaya_Store.Application.Features.Offers.Requests.Queries;
using Abaya_Store.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Offers.Handlers.Queries
{
	public class GetOfferDetailRequestHandler : IRequestHandler<GetOfferDetailRequest, OfferDto>
	{
		private readonly IOfferRepository _offerRepository;
		private readonly IMapper _mapper;

		public GetOfferDetailRequestHandler(IOfferRepository offerRepository, IMapper mapper)
		{
			_offerRepository = offerRepository;
			_mapper = mapper;
		}
		public async Task<OfferDto> Handle(GetOfferDetailRequest request, CancellationToken cancellationToken)
		{
			var offer = await _offerRepository.GetByIdIncludeAsync(request.Id);

			return _mapper.Map<OfferDto>(offer);
		}
	}
}
