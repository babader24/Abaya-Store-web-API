using Abaya_Store.Application.DTOs.Category;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Categories.Requests.Commands
{
    public class UpdateCategoryCommand : IRequest<Unit>
    {
		public CategoryUpdateDto categoryUpdateDto { get; set; }
	}
}
