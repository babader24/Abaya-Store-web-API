using Abaya_Store.Application.DTOs.CartItem;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.CartItems.Requests.Queries
{
    public class GetCartItemsListRequest : IRequest<List<CartItemDto>>
    {
    }
}
