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
	public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
	{
		private readonly IProductRepository _productRepository;
		private readonly IMapper _mapper;

		public DeleteProductCommandHandler(IProductRepository productRepository, IMapper mapper)
		{
			_productRepository = productRepository;
			_mapper = mapper;
		}
		public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
		{
			var product = await _productRepository.GetByIdAsync(request.Id);

			if (product == null)
				throw new NotFoundException(nameof(product), request.Id);

			await _productRepository.DeleteAsync(product);
			return Unit.Value;
		}
	}
}
