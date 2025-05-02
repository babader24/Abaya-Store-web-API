using Abaya_Store.Application.DTOs.Product.Validator;
using Abaya_Store.Application.Exceptions;
using Abaya_Store.Application.Features.Products.Requests.Commands;
using Abaya_Store.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Products.Handlers.Commands
{
	public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
	{
		private readonly IProductRepository _productRepository;
		private readonly IMapper _mapper;

		public UpdateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
		{
			_productRepository = productRepository;
			_mapper = mapper;
		}
		public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
		{
			var updateValidator = new ProductUpdateDtoValidator();
			var updateResult = updateValidator.Validate(request.updateDto);

			if (updateResult.IsValid == false)
				throw new ValidationException(updateResult);

			var product = await _productRepository.GetByIdAsync(request.updateDto.Id);

			if(product != null)
			{
				_mapper.Map(request.updateDto, product);
				await _productRepository.UpdateAsync(product);
			}
			return Unit.Value;
		}
	}
}
