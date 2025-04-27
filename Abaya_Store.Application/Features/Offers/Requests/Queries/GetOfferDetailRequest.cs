using Abaya_Store.Application.DTOs.Offer;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Offers.Requests.Queries
{
    public class GetOfferDetailRequest : IRequest<OfferDto>
    {
		public int Id { get; set; }
	}
}
