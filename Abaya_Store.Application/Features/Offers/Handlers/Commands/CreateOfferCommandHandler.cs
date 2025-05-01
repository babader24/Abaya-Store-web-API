using Abaya_Store.Application.DTOs.Offer.Validator;
using Abaya_Store.Application.Features.Offers.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using Abaya_Store.Application.Responses;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Offers.Handlers.Commands
{
	public class CreateOfferCommandHandler : IRequestHandler<CreateOfferCommand, BaseCommandRespons>
	{
		private readonly IOfferRepository _offerRepository;
		private readonly IMapper _mapper;

		public CreateOfferCommandHandler(IOfferRepository offerRepository, IMapper mapper)
		{
			_offerRepository = offerRepository;
			_mapper = mapper;
		}
		public async Task<BaseCommandRespons> Handle(CreateOfferCommand request, CancellationToken cancellationToken)
		{
			var response = new BaseCommandRespons();
			var createValidator = new OfferCreateDtoValidator();
			var createValidatorResult = createValidator.Validate(request.createDto);

			if (createValidatorResult.IsValid == false)
				response.Failure(createValidatorResult.Errors.Select(e => e.ErrorMessage).ToList());

			var offer = _mapper.Map<Offer>(request.createDto);

			offer = await _offerRepository.AddAsync(offer);

			response.Success(offer.Id);
			return response;
		}
	}
}
