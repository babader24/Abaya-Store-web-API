using Abaya_Store.Application.DTOs.Customer;
using Abaya_Store.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Customers.Requests.Commands
{
    public class CreateCustomerCommand : IRequest<BaseCommandRespons>
    {
		public CustomerCreateDto CustomerCreateDto { get; set; }
	}
}
