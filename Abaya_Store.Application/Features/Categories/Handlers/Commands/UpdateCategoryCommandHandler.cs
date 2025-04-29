using Abaya_Store.Application.DTOs.Category.Validator;
using Abaya_Store.Application.Features.Categories.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Categories.Handlers.Commands
{
	public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, Unit>
	{
		private readonly ICategoryRepository _categoryRepository;
		private readonly IMapper _mapper;

		public UpdateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
		{
			_categoryRepository = categoryRepository;
			_mapper = mapper;
		}
		public async Task<Unit> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
		{
			var validator = new CategoryUpdateDtoValidator();
			var validatorResult = validator.Validate(request.categoryUpdateDto);

			if (!validatorResult.IsValid)
				throw new Exception();

			var category = await _categoryRepository.GetByIdAsync(request.categoryUpdateDto.Id);

			if(category != null)
			{
				_mapper.Map(request.categoryUpdateDto, category);

				await _categoryRepository.UpdateAsync(category);
			}
			return Unit.Value;
		}
	}
}
