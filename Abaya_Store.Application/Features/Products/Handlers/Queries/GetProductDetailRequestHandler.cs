using Abaya_Store.Application.DTOs.Product;
using Abaya_Store.Application.Features.Products.Requests.Queries;
using Abaya_Store.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Products.Handlers.Queries
{
	public class GetProductDetailRequestHandler : IRequestHandler<GetProductDetailRequest, ProductDto>
	{
		private readonly IProductRepository _productRepository;
		private readonly IMapper _mapper;

		public GetProductDetailRequestHandler(IProductRepository productRepository, IMapper mapper)
		{
			_productRepository = productRepository;
			_mapper = mapper;
		}
		public async Task<ProductDto> Handle(GetProductDetailRequest request, CancellationToken cancellationToken)
		{
			var product = await _productRepository.GetByIdIncludeAsync(request.Id);

			return _mapper.Map<ProductDto>(product);
		}
	}
}
