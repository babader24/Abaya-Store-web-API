using Abaya_Store.Application.DTOs.Product;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.Products.Requests.Queries
{
    public class GetProductDetailRequest : IRequest<ProductDto>
    {
		public int Id { get; set; }
	}
}
