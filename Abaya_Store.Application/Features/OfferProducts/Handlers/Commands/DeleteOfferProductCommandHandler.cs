using Abaya_Store.Application.Exceptions;
using Abaya_Store.Application.Features.OfferProducts.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.OfferProducts.Handlers.Commands
{
	public class DeleteOfferProductCommandHandler : IRequestHandler<DeleteOfferProductCommand>
	{
		private readonly IOfferProductRepository _offerProductRepository;
		private readonly IMapper _mapper;

		public DeleteOfferProductCommandHandler(IOfferProductRepository offerProductRepository, IMapper mapper)
		{
			_offerProductRepository = offerProductRepository;
			_mapper = mapper;
		}
		public async Task<Unit> Handle(DeleteOfferProductCommand request, CancellationToken cancellationToken)
		{
			var offerProduct = await _offerProductRepository.GetByIdAsync(request.Id);

			if (offerProduct == null)
				throw new NotFoundException(nameof(offerProduct), request.Id);

			await _offerProductRepository.DeleteAsync(offerProduct);

			return Unit.Value;
		}
	}
}
