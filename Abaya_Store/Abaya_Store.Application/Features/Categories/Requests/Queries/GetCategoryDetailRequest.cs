using Abaya_Store.Application.DTOs.Category;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Categories.Requests.Queries
{
    public class GetCategoryDetailRequest : IRequest<CategoryDto>
    {
		public int Id { get; set; }
	}
}
