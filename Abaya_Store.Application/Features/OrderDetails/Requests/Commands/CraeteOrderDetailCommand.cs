using Abaya_Store.Application.DTOs.OrderDetaile;
using Abaya_Store.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.OrderDetails.Requests.Commands
{
    public class CraeteOrderDetailCommand : IRequest<BaseCommandRespons>
    {
		public OrderDetailCreateDto createDto  { get; set; }
	}
}
