using Abaya_Store.Application.DTOs.Product.Validator;
using Abaya_Store.Application.Features.Products.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
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
	public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
	{
		private readonly IProductRepository _productRepository;
		private readonly IMapper _mapper;

		public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
		{
			_productRepository = productRepository;
			_mapper = mapper;
		}
		public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
		{
			var createValidator = new ProductCreateDtoValidator();
			var createResult = createValidator.Validate(request.createDto);

			if (!createResult.IsValid)
				throw new Exception(string.Join("\n", createResult.Errors));


			var product = _mapper.Map<Product>(request.createDto);

			product = await _productRepository.AddAsync(product);

			return product.Id;
		}
	}
}
