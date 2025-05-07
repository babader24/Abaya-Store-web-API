using Abaya_Store.Application.DTOs.Category.Validator;
using Abaya_Store.Application.Features.Categories.Requests.Commands;
using Abaya_Store.Application.Contracts.Persistence;
using Abaya_Store.Application.Responses;
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
	public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, BaseCommandRespons>
	{
		private readonly ICategoryRepository _categoryRepository;
		private readonly IMapper _mapper;

		public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
		{
			_categoryRepository = categoryRepository;
			_mapper = mapper;
		}
		public async Task<BaseCommandRespons> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
		{
			var response = new BaseCommandRespons();
			var validator = new CategoryCreateDtoValidator();
			var validatorResult = validator.Validate(request.categoryCreateDto);

			if (validatorResult.IsValid == false)
				response = response.Failure(validatorResult.Errors.Select(e => e.ErrorMessage).ToList());

			var category = _mapper.Map<Category>(request.categoryCreateDto);

			category = await _categoryRepository.AddAsync(category);

			response = response.Success(category.Id);
			return response;
		}
	}
}
