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
	public class GetCategoryListRequestHandler : IRequestHandler<GetCategoryListRequest, List<CategoryListDto>>
	{
		private readonly ICategoryRepository _categoryRepository;
		private readonly IMapper _mapper;

		public GetCategoryListRequestHandler(ICategoryRepository categoryRepository, IMapper mapper)
		{
			_categoryRepository = categoryRepository;
			_mapper = mapper;
		}
		public async Task<List<CategoryListDto>> Handle(GetCategoryListRequest request, CancellationToken cancellationToken)
		{
			var categories = await _categoryRepository.GetAllAsync();

			return _mapper.Map<List<CategoryListDto>>(categories);
		}
	}
}
