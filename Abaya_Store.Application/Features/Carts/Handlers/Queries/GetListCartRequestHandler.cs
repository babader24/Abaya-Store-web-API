using Abaya_Store.Application.DTOs.Cart;
using Abaya_Store.Application.Features.Carts.Requests.Queries;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace Abaya_Store.Application.Features.Carts.Handlers.Queries
{
	public class GetListCartRequestHandler : IRequestHandler<GetListCartRequest,List<CartDto>>
	{
		private readonly ICartRepository _cartRepository;
		private readonly IMapper _mapper;

		public GetListCartRequestHandler(ICartRepository cartRepository, IMapper mapper)
		{
			_cartRepository = cartRepository;
			_mapper = mapper;
		}
		public async Task<List<CartDto>> Handle(GetListCartRequest request, CancellationToken cancellationToken)
		{
			var cart = await _cartRepository.GetAllIncludingAsync();

			return _mapper.Map<List<CartDto>>(cart);
		}
	}
}
