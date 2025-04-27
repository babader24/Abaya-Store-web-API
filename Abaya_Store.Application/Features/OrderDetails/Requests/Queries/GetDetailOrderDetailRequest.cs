using Abaya_Store.Application.DTOs.OrderDetaile;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.OrderDetails.Requests.Queries
{
    public class GetDetailOrderDetailRequest : IRequest<OrderDetailDto>
    {
		public int Id { get; set; }
	}
}
