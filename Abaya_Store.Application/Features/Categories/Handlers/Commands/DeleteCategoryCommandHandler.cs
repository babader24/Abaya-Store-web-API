using Abaya_Store.Application.Exceptions;
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
	public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, Unit>
	{
		private readonly ICategoryRepository _categoryRepository;
		private readonly IMapper _mapper;

		public DeleteCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
		{
			_categoryRepository = categoryRepository;
			_mapper = mapper;
		}
		public async Task<Unit> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
		{
			var category = await _categoryRepository.GetByIdAsync(request.Id);

			if (category == null)
				throw new NotFoundException(nameof(category), request.Id);

			await _categoryRepository.DeleteAsync(category);

			return Unit.Value;
		}
	}
}
