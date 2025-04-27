using Abaya_Store.Application.DTOs.ShippingInfo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.ShippingInfos.Requests.Commands
{
	public class CreateShippingInfoCommand : IRequest<int>
	{
		public ShippingInfoCreateDto createDto { get; set; }
	}
}
