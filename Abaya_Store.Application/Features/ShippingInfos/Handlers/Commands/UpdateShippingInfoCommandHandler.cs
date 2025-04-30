using Abaya_Store.Application.DTOs.ShippingInfo.Validator;
using Abaya_Store.Application.Exceptions;
using Abaya_Store.Application.Features.ShippingInfos.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace Abaya_Store.Application.Features.ShippingInfos.Handlers.Commands
{
	public class UpdateShippingInfoCommandHandler : IRequestHandler<UpdateShippingInfoCommand>
	{
		private readonly IShippingInfoRepository _shippingInfoRepository;
		private readonly IMapper _mapper;

		public UpdateShippingInfoCommandHandler(IShippingInfoRepository shippingInfoRepository, IMapper mapper)
		{
			_shippingInfoRepository = shippingInfoRepository;
			_mapper = mapper;
		}

		public async Task<Unit> Handle(UpdateShippingInfoCommand request, CancellationToken cancellationToken)
		{
			var updateValidator = new ShippingInfoUpdateDtoValidator();
			var updateResult = updateValidator.Validate(request.updateDto);

			if (updateResult.IsValid == false)
				throw new ValidationException(updateResult);

			var shippingInfo = await _shippingInfoRepository.GetByIdAsync(request.updateDto.Id);

			if (shippingInfo != null)
			{
				_mapper.Map(request.updateDto, shippingInfo);
				await _shippingInfoRepository.UpdateAsync(shippingInfo);
			}

			return Unit.Value;
		}
	}
}
