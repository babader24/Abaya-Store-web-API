using Abaya_Store.Application.DTOs.Cart;
using Abaya_Store.Application.Features.Carts.Requests.Queries;
using Abaya_Store.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Carts.Handlers.Queries
{
	public class GetDetailCartRequestHandler : IRequestHandler<GetDetailCartRequest, CartDto>
	{
		private readonly ICartRepository _cartRepository;
		private readonly IMapper _mapper;

		public GetDetailCartRequestHandler(ICartRepository cartRepository, IMapper mapper)
		{
			_cartRepository = cartRepository;
			_mapper = mapper;
		}
		public async Task<CartDto> Handle(GetDetailCartRequest request, CancellationToken cancellationToken)
		{
			var cart = await _cartRepository.GetByIdIncludeAsync(request.Id);

			return _mapper.Map<CartDto>(cart);
		}
	}	
}
