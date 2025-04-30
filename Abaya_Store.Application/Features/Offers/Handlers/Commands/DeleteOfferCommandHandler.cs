using Abaya_Store.Application.Exceptions;
using Abaya_Store.Application.Features.Offers.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Offers.Handlers.Commands
{
	public class DeleteOfferCommandHandler : IRequestHandler<DeleteOfferCommand>
	{
		private readonly IOfferRepository _offerRepository;
		private readonly IMapper _mapper;

		public DeleteOfferCommandHandler(IOfferRepository offerRepository, IMapper mapper)
		{
			_offerRepository = offerRepository;
			_mapper = mapper;
		}
		public async Task<Unit> Handle(DeleteOfferCommand request, CancellationToken cancellationToken)
		{
			var offer = await _offerRepository.GetByIdAsync(request.Id);

			if (offer == null)
				throw new NotFoundException(nameof(offer), request.Id);

			await _offerRepository.DeleteAsync(offer);

			return Unit.Value;
		}
	}
}
