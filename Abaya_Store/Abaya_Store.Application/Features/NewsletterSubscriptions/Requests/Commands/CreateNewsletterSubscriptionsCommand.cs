﻿using Abaya_Store.Application.DTOs.NewsletterSubscription;
using Abaya_Store.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaya_Store.Application.Features.NewsletterSubscriptions.Requests.Commands
{
    public class CreateNewsletterSubscriptionsCommand : IRequest<BaseCommandRespons>
    {
		public NewsletterSubscriptionCreateDto newsletterSubscription { get; set; }
	}
}
