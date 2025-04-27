using Abaya_Store.Application.DTOs.OfferProduct;
using Abaya_Store.Application.Features.OfferProducts.Requests.Queries;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.OfferProducts.Handlers.Queries
{
	public class GetDetailOfferProductRequestHandler : IRequestHandler<GetDetailOfferProductRequest, OfferProductDto>
	{
		private readonly IOfferProductRepository _offerProductRepository;
		private readonly IMapper _mapper;

		public GetDetailOfferProductRequestHandler(IOfferProductRepository offerProductRepository, IMapper mapper)
		{
			_offerProductRepository = offerProductRepository;
			_mapper = mapper;
		}
		public async Task<OfferProductDto> Handle(GetDetailOfferProductRequest request, CancellationToken cancellationToken)
		{
			var offer = await _offerProductRepository.GetByIdIncludeAsync(request.Id);

			return _mapper.Map<OfferProductDto>(offer);
		}
	}
}
