using Abaya_Store.Application.DTOs.Category.Validator;
using Abaya_Store.Application.Features.Categories.Requests.Commands;
using Abaya_Store.Application.Persistence.Contracts;
using Abaya_Store.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Categories.Handlers.Commands
{
	public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, int>
	{
		private readonly ICategoryRepository _categoryRepository;
		private readonly IMapper _mapper;

		public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
		{
			_categoryRepository = categoryRepository;
			_mapper = mapper;
		}
		public async Task<int> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
		{
			var validator = new CategoryCreateDtoValidator();
			var validatorResult = validator.Validate(request.categoryCreateDto);

			if (!validatorResult.IsValid)
				throw new Exception();

			var category = _mapper.Map<Category>(request.categoryCreateDto);

			category = await _categoryRepository.AddAsync(category);

			return category.Id;
		}
	}
}
