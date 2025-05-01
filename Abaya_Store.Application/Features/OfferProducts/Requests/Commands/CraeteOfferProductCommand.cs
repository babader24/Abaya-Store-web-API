using Abaya_Store.Application.DTOs.OfferProduct;
using Abaya_Store.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.OfferProducts.Requests.Commands
{
    public class CraeteOfferProductCommand : IRequest<BaseCommandRespons>
    {
		public OfferProductCreateDto createDto { get; set; }
	}
}
