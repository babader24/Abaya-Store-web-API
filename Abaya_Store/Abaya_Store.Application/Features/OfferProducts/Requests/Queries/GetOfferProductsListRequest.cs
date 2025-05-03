using Abaya_Store.Application.DTOs.OfferProduct;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.OfferProducts.Requests.Queries
{
    public class GetOfferProductsListRequest : IRequest<List<OfferProductListDto>>
    {
    }
}
