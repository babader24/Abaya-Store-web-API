using Abaya_Store.Application.DTOs.OrderDetaile;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.OrderDetails.Requests.Commands
{
    public class CraeteOrderDetailCommand : IRequest<int>
    {
		public OrderDetailCreateDto createDto  { get; set; }
	}
}
