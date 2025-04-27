using Abaya_Store.Application.DTOs.OfferProduct;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.OfferProducts.Requests.Commands
{
    public class CraeteOfferProductCommand : IRequest<int>
    {
		public OfferProductCreateDto createDto { get; set; }
	}
}
