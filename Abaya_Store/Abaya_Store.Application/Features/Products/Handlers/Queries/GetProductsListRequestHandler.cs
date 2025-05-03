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
	public class GetProductsListRequestHandler : IRequestHandler<GetProductsListRequest, List<ProductListDto>>
	{
		private readonly IProductRepository _productRepository;
		private readonly IMapper _mapper;

		public GetProductsListRequestHandler(IProductRepository productRepository, IMapper mapper)
		{
			_productRepository = productRepository;
			_mapper = mapper;
		}
		public async Task<List<ProductListDto>> Handle(GetProductsListRequest request, CancellationToken cancellationToken)
		{
			var products = await _productRepository.GetAllAsync();

			return _mapper.Map<List<ProductListDto>>(products);
		}
	}
}
