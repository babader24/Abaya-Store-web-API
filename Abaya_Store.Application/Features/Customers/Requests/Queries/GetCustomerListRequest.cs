using Abaya_Store.Application.DTOs.Customer;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Customers.Requests.Queries
{
    public class GetCustomerListRequest : IRequest<List<CustomerListDto>>
    {

    }
}
