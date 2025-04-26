using Abaya_Store.Application.DTOs.Bill;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Bills.Requests.Queries
{
	public class GetBillListRequest : IRequest<List<BillDto>>
    {
    }
}
