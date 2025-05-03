using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Categories.Requests.Commands
{
    public class DeleteCategoryCommand : IRequest<Unit>
    {
		public int Id { get; set; }
	}
}
