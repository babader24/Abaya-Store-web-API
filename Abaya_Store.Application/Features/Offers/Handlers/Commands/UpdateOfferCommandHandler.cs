using Abaya_Store.Application.DTOs.Offer.Validator;
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
	public class UpdateOfferCommandHandler : IRequestHandler<UpdateOfferCommand>
	{
		private readonly IOfferRepository _offerRepository;
		private readonly IMapper _mapper;

		public UpdateOfferCommandHandler(IOfferRepository offerRepository, IMapper mapper)
		{
			_offerRepository = offerRepository;
			_mapper = mapper;
		}
		public async Task<Unit> Handle(UpdateOfferCommand request, CancellationToken cancellationToken)
		{
			var updateValidator = new OfferUpdateDtoValidator();
			var updateValidatorResult = updateValidator.Validate(request.updateDto);

			if (!updateValidatorResult.IsValid)
				throw new Exception(updateValidatorResult.ToString());

			var offer = await _offerRepository.GetByIdAsync(request.updateDto.Id);

			if(offer != null)
			{
				_mapper.Map(request.updateDto, offer);

				await _offerRepository.UpdateAsync(offer);
			}
			return Unit.Value;
		}
	}
}
