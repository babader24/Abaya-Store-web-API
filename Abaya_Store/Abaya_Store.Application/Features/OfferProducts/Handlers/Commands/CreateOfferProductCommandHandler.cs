using Abaya_Store.Application.DTOs.OfferProduct.Validator;
using Abaya_Store.Application.Features.OfferProducts.Requests.Commands;
using Abaya_Store.Application.Contracts.Persistence;
using Abaya_Store.Application.Responses;
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
	public class CreateOfferProductCommandHandler : IRequestHandler<CreateOfferProductCommand, BaseCommandRespons>
	{
		private readonly IOfferProductRepository _offerProductRepository;
		private readonly IMapper _mapper;

		public CreateOfferProductCommandHandler(IOfferProductRepository offerProductRepository, IMapper mapper)
		{
			_offerProductRepository = offerProductRepository;
			_mapper = mapper;
		}
		public async Task<BaseCommandRespons> Handle(CreateOfferProductCommand request, CancellationToken cancellationToken)
		{
			var response = new BaseCommandRespons();
			var createProductValidator = new OfferProductCreateDtoValidator();
			var createProductResult = createProductValidator.Validate(request.createDto);

			if (createProductResult.IsValid == false)
				response.Failure(createProductResult.Errors.Select(e => e.ErrorMessage).ToList());

			var offerProduct = _mapper.Map<OfferProduct>(request.createDto);

			offerProduct = await _offerProductRepository.AddAsync(offerProduct);

			response.Success(offerProduct.Id);
			return response;
		}
	}
}
