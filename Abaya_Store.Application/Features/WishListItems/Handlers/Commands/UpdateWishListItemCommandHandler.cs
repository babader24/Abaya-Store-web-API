using Abaya_Store.Application.DTOs.WishListItem.Validator;
using Abaya_Store.Application.Exceptions;
using Abaya_Store.Application.Features.WishListItems.Requests.Commands;
using Abaya_Store.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;

namespace Abaya_Store.Application.Features.WishListItems.Handlers.Commands
{
	public class UpdateWishListItemCommandHandler : IRequestHandler<UpdateWishListItemCommand>
	{
		private readonly IWishListItemRepository _wishListItemRepository;
		private readonly IMapper _mapper;

		public UpdateWishListItemCommandHandler(IWishListItemRepository wishListItemRepository, IMapper mapper)
		{
			_wishListItemRepository = wishListItemRepository;
			_mapper = mapper;
		}

		public async Task<Unit> Handle(UpdateWishListItemCommand request, CancellationToken cancellationToken)
		{
			var updateValidator = new WishListItemUpdateDtoValidator();
			var updateResult = updateValidator.Validate(request.UpdateDto);

			if (!updateResult.IsValid)
				throw new ValidationException(updateResult);

			var item = await _wishListItemRepository.GetByIdAsync(request.UpdateDto.Id);

			_mapper.Map(request.UpdateDto, item);
			await _wishListItemRepository.UpdateAsync(item);

			return Unit.Value;
		}
	}
}
