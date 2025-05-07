using Abaya_Store.Application.DTOs.Product.Validator;
using Abaya_Store.Application.Features.Products.Requests.Commands;
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

namespace Abaya_Store.Application.Features.Products.Handlers.Commands
{
	public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, BaseCommandRespons>
	{
		private readonly IProductRepository _productRepository;
		private readonly IMapper _mapper;

		public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
		{
			_productRepository = productRepository;
			_mapper = mapper;
		}
		public async Task<BaseCommandRespons> Handle(CreateProductCommand request, CancellationToken cancellationToken)
		{
			var response = new BaseCommandRespons();
			var createValidator = new ProductCreateDtoValidator();
			var createResult = createValidator.Validate(request.createDto);

			if (createResult.IsValid == false)
				response = response.Failure(createResult.Errors.Select(e => e.ErrorMessage).ToList());


			var product = _mapper.Map<Product>(request.createDto);

			product = await _productRepository.AddAsync(product);

			response = response.Success(product.Id);
			return response;
		}
	}
}
