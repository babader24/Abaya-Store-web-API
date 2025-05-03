using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Customers.Requests.Commands
{
    public class DeleteCustomerCommand : IRequest<Unit>
    {
		public int Id { get; set; }
	}
}
