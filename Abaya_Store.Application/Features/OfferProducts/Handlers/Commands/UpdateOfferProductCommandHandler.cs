using Abaya_Store.Application.DTOs.OfferProduct.Validator;
using Abaya_Store.Application.Exceptions;
using Abaya_Store.Application.Features.OfferProducts.Requests.Commands;
using Abaya_Store.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.OfferProducts.Handlers.Commands
{
	public class UpdateOfferProductCommandHandler : IRequestHandler<UpdateOfferProductCommand>
	{
		private readonly IOfferProductRepository _offerProductRepository;
		private readonly IMapper _mapper;

		public UpdateOfferProductCommandHandler(IOfferProductRepository offerProductRepository, IMapper mapper)
		{
			_offerProductRepository = offerProductRepository;
			_mapper = mapper;
		}
		public async Task<Unit> Handle(UpdateOfferProductCommand request, CancellationToken cancellationToken)
		{
			var updateProductValidator = new OfferProductUpdateDtoValidator();
			var updateProductResult = updateProductValidator.Validate(request.updateDto);


			if (updateProductResult.IsValid == false)
				throw new ValidationException(updateProductResult);

			var offerProduct = await _offerProductRepository.GetByIdAsync(request.updateDto.Id);

			if(offerProduct != null)
			{
				_mapper.Map(request.updateDto, offerProduct);

				await _offerProductRepository.UpdateAsync(offerProduct);
			}
			return Unit.Value;
		}
	}
}
