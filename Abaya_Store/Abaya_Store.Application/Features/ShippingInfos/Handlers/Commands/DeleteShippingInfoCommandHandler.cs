using Abaya_Store.Application.Exceptions;
using Abaya_Store.Application.Features.ShippingInfos.Requests.Commands;
using Abaya_Store.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;

namespace Abaya_Store.Application.Features.ShippingInfos.Handlers.Commands
{
	public class DeleteShippingInfoCommandHandler : IRequestHandler<DeleteShippingInfoCommand>
	{
		private readonly IShippingInfoRepository _shippingInfoRepository;
		private readonly IMapper _mapper;

		public DeleteShippingInfoCommandHandler(IShippingInfoRepository shippingInfoRepository, IMapper mapper)
		{
			_shippingInfoRepository = shippingInfoRepository;
			_mapper = mapper;
		}

		public async Task<Unit> Handle(DeleteShippingInfoCommand request, CancellationToken cancellationToken)
		{
			var shippingInfo = await _shippingInfoRepository.GetByIdAsync(request.Id);

			if (shippingInfo == null)
				throw new NotFoundException(nameof(shippingInfo), request.Id);

			await _shippingInfoRepository.DeleteAsync(shippingInfo);
			return Unit.Value;
		}
	}
}
