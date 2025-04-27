using Abaya_Store.Application.DTOs.NewsletterSubscription;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.NewsletterSubscriptions.Requests.Queries
{
    public class GetDetailNewsletterSubscriptionRequest : IRequest<NewsletterSubscriptionDto>
    {
		public int Id { get; set; }
	}
}
