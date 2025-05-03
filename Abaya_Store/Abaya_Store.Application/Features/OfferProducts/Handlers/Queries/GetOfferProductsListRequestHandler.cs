using Abaya_Store.Application.DTOs.OfferProduct;
using Abaya_Store.Application.Features.OfferProducts.Requests.Queries;
using Abaya_Store.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.OfferProducts.Handlers.Queries
{
	public class GetOfferProductsListRequestHandler : IRequestHandler<GetOfferProductsListRequest, List<OfferProductListDto>>
	{
		private readonly IOfferProductRepository _offerProductRepository;
		private readonly IMapper _mapper;

		public GetOfferProductsListRequestHandler(IOfferProductRepository offerProductRepository, IMapper mapper)
		{
			_offerProductRepository = offerProductRepository;
			_mapper = mapper;
		}
		public async Task<List<OfferProductListDto>> Handle(GetOfferProductsListRequest request, CancellationToken cancellationToken)
		{
			var offerproducts = await _offerProductRepository.GetAllIncludingAsync();

			return _mapper.Map<List<OfferProductListDto>>(offerproducts);
		}
	}
}
