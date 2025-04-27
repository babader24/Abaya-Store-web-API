using Abaya_Store.Application.Features.OfferProducts.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.OfferProducts.Handlers.Commands
{
	public class CraeteOfferProductCommandHandler : IRequestHandler<CraeteOfferProductCommand, int>
	{
		private readonly IOfferProductRepository _offerProductRepository;
		private readonly IMapper _mapper;

		public CraeteOfferProductCommandHandler(IOfferProductRepository offerProductRepository, IMapper mapper)
		{
			_offerProductRepository = offerProductRepository;
			_mapper = mapper;
		}
		public async Task<int> Handle(CraeteOfferProductCommand request, CancellationToken cancellationToken)
		{
			var offerProduct = _mapper.Map<OfferProduct>(request.createDto);

			offerProduct = await _offerProductRepository.AddAsync(offerProduct);

			return offerProduct.Id;
		}
	}
}
