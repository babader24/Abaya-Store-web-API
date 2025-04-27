using Abaya_Store.Application.DTOs.Category;
using Abaya_Store.Application.Features.Categories.Requests.Queries;
using Abaya_Store.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Categories.Handlers.Queries
{
	public class GetCategoryDetailRequestHandler : IRequestHandler<GetCategoryDetailRequest, CategoryDto>
	{
		private readonly ICategoryRepository _categoryRepository;
		private readonly IMapper _mapper;

		public GetCategoryDetailRequestHandler(ICategoryRepository categoryRepository, IMapper mapper)
		{
			_categoryRepository = categoryRepository;
			_mapper = mapper;
		}
		public async Task<CategoryDto> Handle(GetCategoryDetailRequest request, CancellationToken cancellationToken)
		{
			var category = await _categoryRepository.GetByIdAsync(request.Id);

			return _mapper.Map<CategoryDto>(category);
		}
	}
}
